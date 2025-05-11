using Microsoft.EntityFrameworkCore;
using TravelGuide.Models;

namespace TravelGuide.Data
{
    public class TravelGuideDbContext : DbContext
    {
        public TravelGuideDbContext(DbContextOptions<TravelGuideDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Attraction> Attractions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attraction>()
                .Property(a => a.EntranceFee)
                .HasPrecision(18, 2);

            // Добавляем города
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Москва",
                    Region = "Центральный",
                    Population = 12655050,
                    History = "Москва — столица России, крупнейший город страны.",
                    PhotoPath = "moscow.jpg"
                },
                new City
                {
                    Id = 2,
                    Name = "Санкт-Петербург",
                    Region = "Северо-Западный",
                    Population = 5392992,
                    History = "Санкт-Петербург — культурная столица России.",
                    PhotoPath = "spb.jpg"
                },
                new City
                {
                    Id = 3,
                    Name = "Казань",
                    Region = "Приволжский",
                    Population = 1257391,
                    History = "Казань — столица Республики Татарстан.",
                    PhotoPath = "kazan.jpg"
                }
            );

            // Добавляем достопримечательности
            modelBuilder.Entity<Attraction>().HasData(
                new Attraction
                {
                    Id = 1,
                    Name = "Красная площадь",
                    Description = "Главная площадь Москвы",
                    History = "История Красной площади...",
                    PhotoPath = "red-square.jpg",
                    WorkingHours = "Круглосуточно",
                    EntranceFee = 0,
                    CityId = 1
                },
                new Attraction
                {
                    Id = 2,
                    Name = "Эрмитаж",
                    Description = "Один из крупнейших музеев мира",
                    History = "Основан в 1764 году Екатериной II",
                    PhotoPath = "hermitage.jpg",
                    WorkingHours = "10:00-18:00, выходной - понедельник",
                    EntranceFee = 800,
                    CityId = 2
                },
                new Attraction
                {
                    Id = 3,
                    Name = "Казанский Кремль",
                    Description = "Историческая крепость",
                    History = "Объект Всемирного наследия ЮНЕСКО",
                    PhotoPath = "kazan-kremlin.jpg",
                    WorkingHours = "08:00-20:00",
                    EntranceFee = 500,
                    CityId = 3
                },
                new Attraction
                {
                    Id = 4,
                    Name = "Московский Кремль",
                    Description = "Исторический комплекс в центре Москвы",
                    History = "Главный общественно-политический комплекс страны",
                    PhotoPath = "moscow-kremlin.jpg",
                    WorkingHours = "10:00-17:00",
                    EntranceFee = 1000,
                    CityId = 1
                }
            );
        }
    }
}
