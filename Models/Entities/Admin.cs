﻿using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
