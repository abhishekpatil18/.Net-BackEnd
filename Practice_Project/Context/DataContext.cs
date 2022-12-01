using Microsoft.EntityFrameworkCore;
using Practice_Project.Model;

namespace Practice_Project.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
