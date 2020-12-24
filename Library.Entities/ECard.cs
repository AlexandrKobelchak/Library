using Library.Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class ECard : DbEntity
    {
        [Column("emploeeId")]
        public int EmployeeId{ get; set; }
        public Emploee Emploee { get; set; }
        [Column("bookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Column("libId")]
        public int LibId { get; set; }
        public Librarian Librarian { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
    }
}
