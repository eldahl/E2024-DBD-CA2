﻿// <auto-generated />
using AmazonKiller2000;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AmazonKiller2000.Migrations
{
    [DbContext(typeof(PostgresDBContext))]
    partial class PostgresDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AmazonKiller2000.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("AmazonKiller2000.Models.Book", b =>
                {
                    b.Property<int>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ISBN"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("StockLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ISBN");

                    b.HasIndex("AuthorId")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AmazonKiller2000.Models.Book", b =>
                {
                    b.HasOne("AmazonKiller2000.Models.Author", "Author")
                        .WithOne()
                        .HasForeignKey("AmazonKiller2000.Models.Book", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}