﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TakeawayDeliveryFood.Infrastructure.Data;

#nullable disable

namespace TakeawayDeliveryFood.Data.Migrations
{
    [DbContext(typeof(TakeawayDeliveryFoodDbContext))]
    [Migration("20221125101512_AddingDishTable")]
    partial class AddingDishTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.CuisineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("CuisineTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Indian"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Burgers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sishi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Italian"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Asian"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bulgarian"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Arab"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Vegetarian"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Europian"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Mexican"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Fine dine"
                        });
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CuisineTypeId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryCost")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DeliveryTime")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MinOrderAmount")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RestaurantImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingHours")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.HasIndex("CuisineTypeId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CuisineTypeId = 8,
                            DeliveryCost = "Free",
                            DeliveryTime = "20 - 50 min.",
                            Description = "Authentic Italian pizza",
                            MinOrderAmount = "Min. 10.00 lv.",
                            Name = "Genaro`s pizza",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse1.mm.bing.net/th?id=OIP.VIHoNlxPTkXfW2i6DgfIbwHaF7&pid=Api",
                            WorkingHours = "12:00 - 22:00"
                        },
                        new
                        {
                            Id = 2,
                            CuisineTypeId = 1,
                            DeliveryCost = "Free from 30.00 lv.",
                            DeliveryTime = "30 - 50 min.",
                            Description = "Authentic Indian pizza",
                            MinOrderAmount = "Min. 20.00 lv.",
                            Name = "Taj Mahal",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse2.mm.bing.net/th?id=OIP.8gNduGMsG-TnwPqLDlRQVQHaE8&pid=Api",
                            WorkingHours = "11:00 - 23:00"
                        },
                        new
                        {
                            Id = 3,
                            CuisineTypeId = 2,
                            DeliveryCost = "Free from 20.00 lv.",
                            DeliveryTime = "20 - 50 min.",
                            Description = "Best American style burgers",
                            MinOrderAmount = "Min. 20.00 lv.",
                            Name = "Burgers & Fries",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse1.mm.bing.net/th?id=OIP.W0r1nOj-EPrXoziOqjjFPAHaE8&pid=Api",
                            WorkingHours = "11:00 - 23:00"
                        },
                        new
                        {
                            Id = 4,
                            CuisineTypeId = 11,
                            DeliveryCost = "2.99 lv.",
                            DeliveryTime = "20 - 50 min.",
                            Description = "Cosy Mexican restaurant in the heart of the big city",
                            MinOrderAmount = "Min. 20.00 lv.",
                            Name = "El Gatto",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse4.mm.bing.net/th?id=OIP.Q74hg6Rl1KPSs-0sUXcXugHaE8&pid=Api",
                            WorkingHours = "11:00 - 22:00"
                        },
                        new
                        {
                            Id = 5,
                            CuisineTypeId = 3,
                            DeliveryCost = "2.99 lv.",
                            DeliveryTime = "30 - 60 min.",
                            Description = "Authentic sushi prepared from our sushi master",
                            MinOrderAmount = "Min. 20.00 lv.",
                            Name = "Kioto sushi",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse3.mm.bing.net/th?id=OIP.2oT2R6wz3DbEm0NIePcJzwHaE_&pid=Api",
                            WorkingHours = "11:00 - 24:00"
                        },
                        new
                        {
                            Id = 6,
                            CuisineTypeId = 5,
                            DeliveryCost = "5.99 lv.",
                            DeliveryTime = "30 - 60 min.",
                            Description = "Authentic Chinese dishes",
                            MinOrderAmount = "Min. 10.00 lv.",
                            Name = "Golden dragon",
                            Rating = 0.0m,
                            RestaurantImage = "https://tse2.mm.bing.net/th?id=OIP.GvVXxZP0xh8i9a_1XFmTyAHaE8&pid=Api",
                            WorkingHours = "12:00 - 22:00"
                        });
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.Dish", b =>
                {
                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.Entities.Restaurant", null)
                        .WithMany("Dishes")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.Restaurant", b =>
                {
                    b.HasOne("TakeawayDeliveryFood.Infrastructure.Data.Entities.CuisineType", "CuisineType")
                        .WithMany("Restaurants")
                        .HasForeignKey("CuisineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CuisineType");
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.CuisineType", b =>
                {
                    b.Navigation("Restaurants");
                });

            modelBuilder.Entity("TakeawayDeliveryFood.Infrastructure.Data.Entities.Restaurant", b =>
                {
                    b.Navigation("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}
