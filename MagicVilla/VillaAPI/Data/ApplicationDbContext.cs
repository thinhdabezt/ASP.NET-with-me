using Microsoft.EntityFrameworkCore;
using VillaAPI.Models;

namespace VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() 
                {
                    Id = 1,
                    Name = "Boku to GAL ga Fufu ni Narumade",
                    ImageUrl = "https://mangadex.org/covers/cf7b7869-3d9a-4c4d-bd06-249eba113558/72abee3c-5cde-4a6c-bc34-0ea02a1f5148.png",
                    Rate = 5,
                    Price = 1000,
                    Introduction = "Boku to GAL ga Fufu ni Narumade",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Otaku ni Yasashii Gal wa Inai!?",
                    ImageUrl = "https://mangadex.org/covers/ee96e2b7-9af2-4864-9656-649f4d3b6fec/61f990f0-103a-4967-ac64-01dc9938cb5c.jpg.512.jpg",
                    Rate = 5,
                    Price = 1000,
                    Introduction = "Otaku ni Yasashii Gal wa Inai!?",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Sono Bisque Doll wa Koi o Suru",
                    ImageUrl = "https://mangadex.org/covers/aa6c76f7-5f5f-46b6-a800-911145f81b9b/426242c4-b281-4f19-bb79-c4e15ab6bb24.jpg.512.jpg",
                    Rate = 5,
                    Price = 1000,
                    Introduction = "Sono Bisque Doll wa Koi o Suru",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
                );
        }
    }
}
