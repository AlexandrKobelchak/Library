﻿using Library.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("libs")]
    public class Librarian:DbEntity
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

        public List<SCard> SCards { get; set; }

        public List<ECard> ECards { get; set; }
    }
}