﻿// <auto-generated />
using System;
using Gride.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gride.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191129112647_updated")]
    partial class updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gride.Models.Availability", b =>
                {
                    b.Property<int>("AvailabilityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.Property<bool>("Weekly");

                    b.HasKey("AvailabilityID");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("Gride.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeID");

                    b.Property<int?>("MessageID");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("Time");

                    b.HasKey("CommentID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("MessageID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Gride.Models.EmployeeAvailability", b =>
                {
                    b.Property<int>("EmployeeAvailabilityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailabilityID");

                    b.Property<int>("EmployeeID");

                    b.HasKey("EmployeeAvailabilityID");

                    b.HasIndex("AvailabilityID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmployeeAvailabilities");
                });

            modelBuilder.Entity("Gride.Models.EmployeeFunction", b =>
                {
                    b.Property<int>("EmployeeFunctionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID");

                    b.Property<int>("FunctionID");

                    b.HasKey("EmployeeFunctionID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("FunctionID");

                    b.ToTable("EmployeeFunctions");
                });

            modelBuilder.Entity("Gride.Models.EmployeeLocations", b =>
                {
                    b.Property<int>("EmployeeLocationsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeModelID");

                    b.Property<int>("LocationID");

                    b.HasKey("EmployeeLocationsID");

                    b.HasIndex("EmployeeModelID");

                    b.HasIndex("LocationID");

                    b.ToTable("EmployeeLocations");
                });

            modelBuilder.Entity("Gride.Models.EmployeeModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float>("Experience");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("ProfileImage");

                    b.Property<int?>("SupervisorID");

                    b.HasKey("ID");

                    b.ToTable("EmployeeModel");
                });

            modelBuilder.Entity("Gride.Models.EmployeeSkill", b =>
                {
                    b.Property<int>("EmployeeSkillID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeModelID");

                    b.Property<int>("SkillID");

                    b.HasKey("EmployeeSkillID");

                    b.HasIndex("EmployeeModelID");

                    b.HasIndex("SkillID");

                    b.ToTable("EmployeeSkills");
                });

            modelBuilder.Entity("Gride.Models.Function", b =>
                {
                    b.Property<int>("FunctionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("FunctionID");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("Gride.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Additions");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Postalcode");

                    b.Property<string>("Street")
                        .HasMaxLength(100);

                    b.Property<int>("StreetNumber");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Gride.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeID");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("Time");

                    b.HasKey("MessageID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Gride.Models.Shift", b =>
                {
                    b.Property<int>("ShiftID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End");

                    b.Property<int>("LocationID");

                    b.Property<DateTime>("Start");

                    b.HasKey("ShiftID");

                    b.HasIndex("LocationID");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("Gride.Models.ShiftFunction", b =>
                {
                    b.Property<int>("ShiftFunctionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FunctionID");

                    b.Property<int>("MaxEmployees");

                    b.Property<int>("ShiftID");

                    b.HasKey("ShiftFunctionID");

                    b.HasIndex("FunctionID");

                    b.HasIndex("ShiftID");

                    b.ToTable("ShiftFunctions");
                });

            modelBuilder.Entity("Gride.Models.ShiftSkills", b =>
                {
                    b.Property<int>("ShiftskillsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ShiftID");

                    b.Property<int>("SkillID");

                    b.HasKey("ShiftskillsID");

                    b.HasIndex("ShiftID");

                    b.HasIndex("SkillID");

                    b.ToTable("ShiftSkills");
                });

            modelBuilder.Entity("Gride.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SkillID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Gride.Models.Work", b =>
                {
                    b.Property<int>("WorkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Delay");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("Overtime");

                    b.Property<int>("ShiftID");

                    b.HasKey("WorkID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShiftID");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Gride.Models.Comment", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("Gride.Models.Message")
                        .WithMany("Comments")
                        .HasForeignKey("MessageID");
                });

            modelBuilder.Entity("Gride.Models.EmployeeAvailability", b =>
                {
                    b.HasOne("Gride.Models.Availability", "Availability")
                        .WithMany("EmployeeAvailabilities")
                        .HasForeignKey("AvailabilityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany("EmployeeAvailabilities")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.EmployeeFunction", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany("EmployeeFunctions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.EmployeeLocations", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany("EmployeeLocations")
                        .HasForeignKey("EmployeeModelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.EmployeeSkill", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("EmployeeModelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.Message", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("Gride.Models.Shift", b =>
                {
                    b.HasOne("Gride.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.ShiftFunction", b =>
                {
                    b.HasOne("Gride.Models.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Shift", "Shift")
                        .WithMany("ShiftFunctions")
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.ShiftSkills", b =>
                {
                    b.HasOne("Gride.Models.Shift", "Shift")
                        .WithMany("ShiftSkills")
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.Work", b =>
                {
                    b.HasOne("Gride.Models.EmployeeModel", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Shift", "Shift")
                        .WithMany("Works")
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
