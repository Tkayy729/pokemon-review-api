﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models
{
	public class Pokemon
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[Column(TypeName = "date")]
		public DateTime BirthDate { get; set; }
		public ICollection<Review> Reviews { get; set; }
		public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
 
    }

	
}

