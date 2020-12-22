using Library.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("teachers")]
    public class Emploee:DbEntity
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

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}