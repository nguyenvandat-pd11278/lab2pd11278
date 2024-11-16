﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SeverGame106.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name {  get; set; }
        [ForeignKey("Region")]
        public int RegionId {  get; set; }
        public string? Avatar {  get; set; }
    }
}
