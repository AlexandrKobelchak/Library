using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class BookAuthor
    {
        [Column("authorId")]
        public int AuthorId { get; set; }
        
        [Column("bookId")]
        public int BookId { get; set; }
        
        public Author Author { get; set; }
        
        public Book Book { get; set; }
    }
}
