﻿using System.ComponentModel.DataAnnotations;

namespace GBC_WebDevelopers.Models
{
    public class Technicians
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
