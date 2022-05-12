using Microsoft.EntityFrameworkCore;
using HW_10.Models;
namespace HW_10.infrastructure.DataBase
{
    public class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = HW10Library; User Id = sa; Password = 123456;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<Member> Members { get; set; }

    }
}
