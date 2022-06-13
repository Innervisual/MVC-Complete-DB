﻿// <auto-generated />
using MVC_Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Data.Migrations
{
    [DbContext(typeof(ApplicationDbContent))]
    [Migration("20220611093726_ PersonLanguage association-table")]
    partial class PersonLanguageassociationtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Name");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MVC_Data.Models.Country", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MVC_Data.Models.Language", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.HasIndex("PersonName");

                    b.ToTable("Langs");
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("CityName");

                    b.ToTable("People");
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonName", "LanguageName");

                    b.HasIndex("LanguageName");

                    b.ToTable("PersonLanguages");
                });

            modelBuilder.Entity("MVC_Data.Models.Language", b =>
                {
                    b.HasOne("MVC_Data.Models.Person", null)
                        .WithMany("Languages")
                        .HasForeignKey("PersonName");
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.HasOne("MVC_Data.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.HasOne("MVC_Data.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
