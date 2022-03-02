﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NslAPI.Data;

namespace NslAPI.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220301102003_Added Moderator Role")]
    partial class AddedModeratorRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ae6c7e26-a201-41f7-89b2-25dee26fd23f",
                            ConcurrencyStamp = "68c4cddc-233e-4843-bcd5-8553b5818172",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "dac33ce2-3971-4d9e-ae96-6574455de0c7",
                            ConcurrencyStamp = "de97f054-ca66-43d8-921f-bf70e0cf8188",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "a309a153-98f9-401c-9dd9-155234494816",
                            ConcurrencyStamp = "d7885112-1a58-4127-95c7-b8cfe3b67bc9",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NslAPI.Data.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NslAPI.Data.Fees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPayment")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Fees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountPaid = 200,
                            DateOfPayment = new DateTime(2022, 3, 1, 21, 20, 2, 931, DateTimeKind.Local).AddTicks(5306),
                            FeeType = "Member",
                            MemberId = 1
                        },
                        new
                        {
                            Id = 2,
                            AmountPaid = 200,
                            DateOfPayment = new DateTime(2022, 3, 1, 21, 20, 2, 941, DateTimeKind.Local).AddTicks(6287),
                            FeeType = "Member",
                            MemberId = 2
                        },
                        new
                        {
                            Id = 3,
                            AmountPaid = 100,
                            DateOfPayment = new DateTime(2022, 3, 1, 21, 20, 2, 941, DateTimeKind.Local).AddTicks(6340),
                            FeeType = "Jersey",
                            MemberId = 2
                        });
                });

            modelBuilder.Entity("NslAPI.Data.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Ngunnawal",
                            DOB = new DateTime(1984, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dhanuka.singhe@gmail.com",
                            FName = "Dhanuka",
                            HomePhone = "",
                            IsActive = 1,
                            LName = "Ilandarage",
                            MName = "Sudheera",
                            Mobile = "0432009680",
                            NOKPhone = "0432000222",
                            NextOfKin = "Ryan",
                            Postcode = 2913,
                            ProfilePicture = "",
                            Relationship = "Son",
                            State = "ACT",
                            Street = "7 Igera Place"
                        },
                        new
                        {
                            Id = 2,
                            City = "Ngunnawal",
                            DOB = new DateTime(2014, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ryan.singhe@gmail.com",
                            FName = "Ryan",
                            HomePhone = "",
                            IsActive = 1,
                            LName = "Ilandarage",
                            MName = "Harindu",
                            Mobile = "0432222000",
                            NOKPhone = "0432333999",
                            NextOfKin = "Pavithri",
                            Postcode = 2913,
                            ProfilePicture = "",
                            Relationship = "Mom",
                            State = "ACT",
                            Street = "7 Igera Place"
                        });
                });

            modelBuilder.Entity("NslAPI.Data.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BattingStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BowlingStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JerseyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JerseyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JerseySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("PlayingRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BattingStyle = "Left",
                            BowlingStyle = "Right arm Medium Pace",
                            JerseyName = "Sudeera",
                            JerseyNumber = "23",
                            JerseySize = "M",
                            MemberId = 1,
                            PlayingRole = "Allrounder"
                        });
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
                    b.HasOne("NslAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NslAPI.Data.ApiUser", null)
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

                    b.HasOne("NslAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NslAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NslAPI.Data.Fees", b =>
                {
                    b.HasOne("NslAPI.Data.Member", "Member")
                        .WithMany("Fees")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("NslAPI.Data.Player", b =>
                {
                    b.HasOne("NslAPI.Data.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("NslAPI.Data.Member", b =>
                {
                    b.Navigation("Fees");
                });
#pragma warning restore 612, 618
        }
    }
}
