using Library.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("books")]
    public class Book : DbEntity
    {
        [Required]
        [Column("name")]
        [MaxLength(256)]
        public string Name { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }
        public int Year { get; set; }

        [Column("themeId")]
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        [Column("categoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column("pressId")]
        public int PressId { get; set; }
        public Press Press { get; set; }

        public List<ECard> ECards { get; set; }
        public List<SCard> SCards { get; set; }
        public List<BookAuthor> BooksAuthors{get;set;}
        public List<Author> Authors { get; set; }
    }
}
