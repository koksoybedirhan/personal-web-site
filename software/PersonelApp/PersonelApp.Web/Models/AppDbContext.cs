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
        public DbSet<DerslerAyrintiModel> DersAyrintilar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DerslerModel>()
                .HasOne(d => d.DersAyrintilar)
                .WithOne(d => d.Dersler)
                .HasForeignKey<DerslerAyrintiModel>(d => d.DersId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<YoneticiModel> Yonetici { get; set; }
        public DbSet<BlogModel> Bloglar { get; set; }
        public DbSet<IletisimModel> Iletisim { get; set; }
        public DbSet<HomeModel> Home { get; set; }
    }
}
