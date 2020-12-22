using Library.Domain;
using System;

namespace Library.Entities
{
    public class ECard : DbEntity
    {
        public int EmployeeId{ get; set; }
        public Emploee Emploee { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int LibId { get; set; }
        public Librarian Librarian { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
    }
}
