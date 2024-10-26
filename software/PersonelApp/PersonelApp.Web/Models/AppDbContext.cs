using Microsoft.EntityFrameworkCore;

namespace PersonelApp.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<DerslerModel> Dersler { get; set; }
        public DbSet<KurslarModel> Kurslar { get; set; }
    }
}
