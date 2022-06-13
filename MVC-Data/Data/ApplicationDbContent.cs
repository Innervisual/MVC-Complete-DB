 using Microsoft.EntityFrameworkCore;
using MVC_Data.Models;

namespace MVC_Data.Data
{
    public class ApplicationDbContent : DbContext
    {
        public ApplicationDbContent(DbContextOptions<ApplicationDbContent> options) : base(options)
        {
              
        }

        public DbSet<Person> People { get; set; }  
        public DbSet<City> Cities { get; set; } 
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Langs { get; set; }  
        public DbSet<PersonLanguage> PersonLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //koppling mellan person och car    (Many to many)
            //Koppling mellan person och Language tabellen
            modelbuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Person)        //en person
                .WithMany(p => p.PersonLanguages) //flera språk
                .HasForeignKey(p => p.PersonName);
            //Koppling mellan Language och  person  tabellen        (andra hållet)
            modelbuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Language)
                .WithMany(l => l.PersonLanguages)
                .HasForeignKey(l => l.LanguageName);


            //Koppling city och people (one to many) (one city has many people)
            modelbuilder.Entity<City>()
                .HasMany(c => c.People)
                .WithOne(p => p.City);

            modelbuilder.Entity<Person>() //to make it mutual:
                .HasOne(p => p.City)
                .WithMany(c => c.People);


            // Seeeds
            modelbuilder.Entity<Person>().HasData(new Person { Name = "JP", Id = 1, PhoneNumber = 111 });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Stefan", Id=3, PhoneNumber=333, });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Ian", Id=4, PhoneNumber=444, });
            modelbuilder.Entity<Person>().HasData(new Person { Name="George", Id=5, PhoneNumber=555, });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Svante", Id=6, PhoneNumber=666, });

            modelbuilder.Entity<Language>().HasData(new Language { Name = "English" });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Swedish" });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "French" });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "German" });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Spanish" });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Portugese" });

            modelbuilder.Entity<City>().HasData(new City { Name = "London" });
            modelbuilder.Entity<City>().HasData(new City { Name = "Stockholm" });
            modelbuilder.Entity<City>().HasData(new City { Name = "Paris" });
            modelbuilder.Entity<City>().HasData(new City { Name = "Berlin" });
            modelbuilder.Entity<City>().HasData(new City { Name = "Madrid" });
            modelbuilder.Entity<City>().HasData(new City { Name = "Lissabon" });

            modelbuilder.Entity<Country>().HasData(new Country { Name = "England" });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Sweden" });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "France" });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Germany" });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Spain" });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Portugal" });




        }

    }
}
