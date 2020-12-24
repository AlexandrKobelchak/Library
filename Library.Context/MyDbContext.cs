using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Context
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Emploee> Emploees { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Press> Press { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
        public DbSet<SCard> SCards { get; set; }
        public DbSet<ECard> ECards { get; set; }


        public MyDbContext(DbContextOptions options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Group>()
                .HasOne(gr => gr.Faculty)
                .WithMany(fa => fa.Groups)
                .HasForeignKey(gr => gr.FacultyId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<Emploee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Emploees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<SCard>()
                .HasOne(sc => sc.Book)
                .WithMany(b => b.SCards)
                .HasForeignKey(sc => sc.BookId);

            modelBuilder.Entity<SCard>()
               .HasOne(sc => sc.Student)
               .WithMany(s => s.SCards)
               .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<SCard>()
              .HasOne(sc => sc.Librarian)
              .WithMany(l => l.SCards)
              .HasForeignKey(sc => sc.LibId);

            modelBuilder.Entity<ECard>()
               .HasOne(sc => sc.Book)
               .WithMany(b => b.ECards)
               .HasForeignKey(sc => sc.BookId);

            modelBuilder.Entity<ECard>()
               .HasOne(sc => sc.Emploee)
               .WithMany(s => s.ECards)
               .HasForeignKey(sc => sc.EmployeeId);

            modelBuilder.Entity<ECard>()
              .HasOne(sc => sc.Librarian)
              .WithMany(l => l.ECards)
              .HasForeignKey(sc => sc.LibId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Theme)
                .WithMany(t => t.Books)
                .HasForeignKey(b => b.ThemeId);

            modelBuilder.Entity<Book>()
               .HasOne(b => b.Category)
               .WithMany(c => c.Books)
               .HasForeignKey(b => b.CategoryId);
            
            modelBuilder.Entity<Book>()
             .HasOne(b => b.Press)
             .WithMany(p => p.Books)
             .HasForeignKey(b => b.PressId);
               

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithMany(b => b.Authors)
                .UsingEntity<BookAuthor>(

                    ba => ba.HasOne(pt => pt.Book)
                    .WithMany(ba=>ba.BooksAuthors)
                    .HasForeignKey(x=>x.BookId),
                    
                    ba=>ba.HasOne(pb=>pb.Author)
                    .WithMany(x=>x.BooksAuthors)
                    .HasForeignKey(y=>y.AuthorId),
                    
                    ba=>ba.HasKey(ba => new { ba.BookId, ba.AuthorId })
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
