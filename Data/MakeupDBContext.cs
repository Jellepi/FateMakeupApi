using Microsoft.EntityFrameworkCore;

namespace FateMakeupApi.Data
{
    public class MakeupDBContext(DbContextOptions<MakeupDBContext> options) : DbContext(options)
    {
        public DbSet<Makeup> Makeups => Set<Makeup>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Makeup>().HasData(
            new Makeup
            {
                ID = 1,
                Name = "Matte Lipstick",
                Brand = "MAC",
                Type = "Lipstick",
                Category = "Lips",
                Description = "Long-lasting matte finish lipstick in Ruby Woo shade."
            },
            new Makeup
            {
                ID = 2,
                Name = "Liquid Foundation",
                Brand = "Maybelline",
                Type = "Foundation",
                Category = "Face",
                Description = "Lightweight foundation with full coverage and SPF 20."
            },
            new Makeup
            {
                ID = 3,
                Name = "Eyeshadow Palette",
                Brand = "Urban Decay",
                Type = "Eyeshadow",
                Category = "Eyes",
                Description = "12-shade palette featuring warm neutrals and shimmer tones."
            },
            new Makeup
            {
                ID = 4,
                Name = "Volumizing Mascara",
                Brand = "L'Oréal",
                Type = "Mascara",
                Category = "Eyes",
                Description = "Mascara that provides intense volume and length."
            },
            new Makeup
            {
                ID = 5,
                Name = "Blush Powder",
                Brand = "NARS",
                Type = "Blush",
                Category = "Cheeks",
                Description = "Highly pigmented blush in the shade Orgasm."
            }
            );
        }
    }
}
