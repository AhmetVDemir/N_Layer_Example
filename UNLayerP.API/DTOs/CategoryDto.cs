﻿using System.ComponentModel.DataAnnotations;

namespace UNLayerP.API.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
