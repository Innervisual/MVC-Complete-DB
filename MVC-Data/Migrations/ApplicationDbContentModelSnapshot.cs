﻿// <auto-generated />
using MVC_Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Data.Migrations
{
    [DbContext(typeof(ApplicationDbContent))]
    partial class ApplicationDbContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Data.Models.City", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.HasIndex("CountryName");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Name = "London"
                        },
                        new
                        {
                            Name = "Stockholm"
                        },
                        new
                        {
                            Name = "Paris"
                        },
                        new
                        {
                            Name = "Berlin"
                        },
                        new
                        {
                            Name = "Madrid"
                        },
                        new
                        {
                            Name = "Lissabon"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Country", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Name = "England"
                        },
                        new
                        {
                            Name = "Sweden"
                        },
                        new
                        {
                            Name = "France"
                        },
                        new
                        {
                            Name = "Germany"
                        },
                        new
                        {
                            Name = "Spain"
                        },
                        new
                        {
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Language", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Langs");

                    b.HasData(
                        new
                        {
                            Name = "English"
                        },
                        new
                        {
                            Name = "Swedish"
                        },
                        new
                        {
                            Name = "French"
                        },
                        new
                        {
                            Name = "German"
                        },
                        new
                        {
                            Name = "Spanish"
                        },
                        new
                        {
                            Name = "Portugese"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("CityName");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Name = "JP",
                            Id = 1,
                            PhoneNumber = 111
                        },
                        new
                        {
                            Name = "Stefan",
                            Id = 3,
                            PhoneNumber = 333
                        },
                        new
                        {
                            Name = "Ian",
                            Id = 4,
                            PhoneNumber = 444
                        },
                        new
                        {
                            Name = "George",
                            Id = 5,
                            PhoneNumber = 555
                        },
                        new
                        {
                            Name = "Svante",
                            Id = 6,
                            PhoneNumber = 666
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonName");

                    b.HasIndex("LanguageName");

                    b.ToTable("PersonLanguages");
                });

            modelBuilder.Entity("MVC_Data.Models.City", b =>
                {
                    b.HasOne("MVC_Data.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryName");
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.HasOne("MVC_Data.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityName");
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.HasOne("MVC_Data.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageName");

                    b.HasOne("MVC_Data.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
