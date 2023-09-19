using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController: Controller
{
    private readonly IOwnerRepository _iOwnerRepository;
    private readonly IMapper _mapper;
    
    public OwnerController(IOwnerRepository ownerRepository, IMapper mapper)
    {
        _iOwnerRepository = ownerRepository;
        _mapper = mapper;
    }
    
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
    public IActionResult GetOwners()
    {
        var owners = _mapper.Map<List<OwnerDTO>>(_iOwnerRepository.GetOwners());

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(owners);
    }
    
    [HttpGet("ownerId")]
    [ProducesResponseType(200, Type=typeof(Owner))]
    [ProducesResponseType(400)]
    public IActionResult GetOwner(int ownerId)
    {
        if (!_iOwnerRepository.OwnerExists(ownerId))
            NotFound();
        
        var owner = _mapper.Map<OwnerDTO>(_iOwnerRepository.GetOwner(ownerId));

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(owner);
    }
    
}