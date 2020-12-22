using Library.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class SCard:DbEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int LibId { get; set; }
        public Librarian Librarian { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
    }
}
