﻿using System.ComponentModel.DataAnnotations;

namespace ValidationTest.Shared
{

    public class Starship
    {
        public string? Identifier { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? Classification { get; set; }

        [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "This form disallows unapproved ships.")]
        public bool IsValidatedDesign { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
