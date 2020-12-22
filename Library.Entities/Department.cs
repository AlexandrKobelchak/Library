using Library.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("departments")]
    public class Department:DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(128)]
        public string Name { get; set; }
        public List<Emploee> Teachers { get; set; }
    }
}