using Microsoft.EntityFrameworkCore;
using NookBookWeb.Models;

namespace NookBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        //general setup that will configure DBtext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        //this will create a category table named 'Categories'
        public DbSet<Category> Categories { get; set; }
    }
}
