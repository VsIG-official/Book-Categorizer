using Microsoft.EntityFrameworkCore;
using VsIGBookWeb.Models;

namespace VsIGBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
