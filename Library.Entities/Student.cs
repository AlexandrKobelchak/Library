﻿using Library.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("students")]
    public class Student:DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(128)]
        public string FirstName { get; set; }
        
        [Column("name")]
        [MaxLength(128)]
        public string MiddleName { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(128)]
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}