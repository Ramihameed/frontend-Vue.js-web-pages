using Microsoft.EntityFrameworkCore;
using Test_3.Models;

namespace Test_3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {



        }

        // Define your DbSets (tables) here
        public DbSet<cars> cars { get; set; }
        public DbSet<wheels> wheels { get; set; }

        public DbSet<CarSpecifics> CarSpecifics { get; set; }

        public DbSet<Car2> Car2 { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<cars>().HasKey(c => c.Id);

            // Seeding the cars table with initial data
            modelBuilder.Entity<cars>().HasData(
                new cars { Id = 1, name = "Toyota", price = 20000 },
                new cars { Id = 2, name = "Honda", price = 22000 },
                new cars { Id = 3, name = "Ford", price = 18000 }
            );

            modelBuilder.Entity<Car2>().HasData(
                new Car2 { Id=1,name = "Toyota", type = "1", price = 20000 },
                new Car2 { Id=2,name = "Honda", type = "2", price = 22000 },
                new Car2 { Id=3,name = "Ford",type = "3", price = 18000 }
            );
        }


    }
}


