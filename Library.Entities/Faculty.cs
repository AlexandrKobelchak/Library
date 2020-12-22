using Library.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("faculties")]
    public class Faculty:DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(64)]
        public string Name { get; set; }
        public List<Group> Groups { get; set; }

    }
}
