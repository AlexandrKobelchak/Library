using Library.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("groups")]
    public class Group : DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(32)]
        public string Name { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> Students { get; set; }
    }   
}