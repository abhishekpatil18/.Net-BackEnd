using EF_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Projects> Projects { get; set; }
    }
}
