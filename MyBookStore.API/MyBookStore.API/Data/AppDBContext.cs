using Microsoft.EntityFrameworkCore;
using MyBookStore.API.Data.Models;

namespace MyBookStore.API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
                
        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
                
        }

        public DbSet<Book> Books { get; set; }
    }
}
