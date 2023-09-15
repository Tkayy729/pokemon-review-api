﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models
{
	[Table("Owners")]
	public class Owner
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
		
		public string Lastname { get; set; }
		public string Gym { get; set; }
		public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }

    }
}

