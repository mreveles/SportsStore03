using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SportsStore.Models.Product> Products { get; set; }
        public DbSet<SportsStore.Models.Order> Orders {get;set;}
    }
}