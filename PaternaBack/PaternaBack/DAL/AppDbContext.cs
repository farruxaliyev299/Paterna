using Microsoft.EntityFrameworkCore;
using PaternaBack.Models;

namespace PaternaBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
    }
}
