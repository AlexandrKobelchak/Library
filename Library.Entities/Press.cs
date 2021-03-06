﻿using Library.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("press")]
    public class Press : DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(64)]
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
