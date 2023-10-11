using AviatoShop.Models;
using Microsoft.EntityFrameworkCore;

namespace AviatoShop.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
