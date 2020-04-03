﻿// <auto-generated />
using System;
using LocalBusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusinessApi.Migrations
{
    [DbContext(typeof(LocalBusinessApiContext))]
    partial class LocalBusinessApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusinessApi.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Portland Cuisine",
                            Name = "Restaurant"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "PDX Libraries",
                            Name = "Library"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "PDX Bars",
                            Name = "Bar"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Animals",
                            Name = "Animal"
                        });
                });

            modelBuilder.Entity("LocalBusinessApi.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("EditDate");

                    b.Property<int>("PlaceId");

                    b.Property<int>("Score");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("PlaceId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("LocalBusinessApi.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("EditDate");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PlaceId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            PlaceId = 1,
                            AuthorId = 1,
                            Body = "Test Restaurant",
                            CategoryId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageSource = "#",
                            Title = "Test1"
                        },
                        new
                        {
                            PlaceId = 2,
                            AuthorId = 1,
                            Body = "Test Library",
                            CategoryId = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageSource = "#",
                            Title = "Test2"
                        },
                        new
                        {
                            PlaceId = 3,
                            AuthorId = 1,
                            Body = "Test Restaurant 2",
                            CategoryId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageSource = "#",
                            Title = "Test3"
                        },
                        new
                        {
                            PlaceId = 4,
                            AuthorId = 1,
                            Body = "Test Lib 2",
                            CategoryId = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageSource = "#",
                            Title = "Test4"
                        },
                        new
                        {
                            PlaceId = 5,
                            AuthorId = 1,
                            Body = "Test lib 3",
                            CategoryId = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageSource = "#",
                            Title = "Test5"
                        });
                });

            modelBuilder.Entity("LocalBusinessApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "123@email",
                            Name = "name",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "123@email2",
                            Name = "name2",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "123@email3",
                            Name = "name3",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "123@email4",
                            Name = "name4",
                            Password = "1"
                        });
                });

            modelBuilder.Entity("LocalBusinessApi.Models.Comment", b =>
                {
                    b.HasOne("LocalBusinessApi.Models.Place")
                        .WithMany("Comments")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LocalBusinessApi.Models.Place", b =>
                {
                    b.HasOne("LocalBusinessApi.Models.Category")
                        .WithMany("Places")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
