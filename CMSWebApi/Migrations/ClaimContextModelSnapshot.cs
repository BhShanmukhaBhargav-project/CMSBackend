﻿// <auto-generated />
using System;
using CMSWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMSWebApi.Migrations
{
    [DbContext(typeof(ClaimContext))]
    partial class ClaimContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CMSWebApi.Models.Claim", b =>
                {
                    b.Property<int?>("cId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("cId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("ClaimDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cId");

                    b.ToTable("claim");

                    b.HasData(
                        new
                        {
                            cId = 1,
                            Amount = 20000.0,
                            ClaimDate = "22-10-2022"
                        },
                        new
                        {
                            cId = 2,
                            Amount = 30000.0,
                            ClaimDate = "23-10-2022"
                        });
                });

            modelBuilder.Entity("CMSWebApi.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Key")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("members");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Address = "Ahmedabad",
                            Country = "India",
                            Dob = "2-10-1869",
                            EmailId = "Babita@123",
                            Key = new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 },
                            Password = "Babita",
                            PasswordHash = new byte[] { 135, 100, 47, 176, 242, 162, 33, 20, 139, 129, 99, 66, 14, 218, 74, 240, 226, 69, 59, 15, 207, 253, 52, 78, 250, 70, 16, 222, 113, 213, 177, 195, 186, 10, 88, 235, 211, 198, 155, 23, 45, 183, 118, 75, 12, 164, 3, 171, 106, 208, 23, 63, 201, 238, 34, 39, 100, 42, 208, 183, 120, 93, 239, 124 },
                            PhoneNumber = "66666666",
                            State = "Gujrat",
                            UserName = "Jethalal"
                        },
                        new
                        {
                            Id = 102,
                            Address = "Mumbai",
                            Country = "India",
                            Dob = "3-10-1868",
                            EmailId = "Madhavi@123",
                            Key = new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 },
                            Password = "Madhavi",
                            PasswordHash = new byte[] { 39, 109, 147, 80, 217, 91, 167, 219, 155, 246, 13, 90, 118, 223, 230, 23, 144, 129, 64, 95, 190, 123, 203, 203, 79, 175, 230, 107, 130, 120, 41, 4, 30, 254, 144, 164, 162, 82, 64, 107, 161, 67, 43, 56, 219, 185, 179, 222, 101, 15, 124, 81, 138, 46, 186, 68, 209, 212, 89, 113, 144, 60, 2, 46 },
                            PhoneNumber = "66666667",
                            State = "Maharashtra",
                            UserName = "Bhide"
                        },
                        new
                        {
                            Id = 103,
                            Address = "Begusarai",
                            Country = "India",
                            Dob = "27-09-2000",
                            EmailId = "krantdarshi1999@gmail.com",
                            Key = new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 },
                            Password = "Krant@1999",
                            PasswordHash = new byte[] { 186, 219, 90, 37, 148, 24, 2, 227, 223, 59, 51, 225, 27, 140, 48, 193, 141, 10, 171, 13, 41, 138, 90, 233, 21, 219, 18, 184, 123, 80, 58, 214, 85, 2, 149, 45, 171, 112, 231, 160, 178, 215, 99, 103, 215, 145, 57, 213, 121, 60, 127, 198, 28, 69, 116, 103, 95, 216, 96, 171, 42, 97, 139, 124 },
                            PhoneNumber = "6205629235",
                            Role = "Admin",
                            State = "Bihar",
                            Status = "Active",
                            UserName = "Krantdarshi"
                        });
                });

            modelBuilder.Entity("CMSWebApi.Models.MemberPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CId")
                        .HasColumnType("int");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CId");

                    b.HasIndex("MId");

                    b.HasIndex("PId");

                    b.ToTable("memberPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CId = 1,
                            MId = 101,
                            PId = 1
                        },
                        new
                        {
                            Id = 2,
                            CId = 1,
                            MId = 102,
                            PId = 2
                        });
                });

            modelBuilder.Entity("CMSWebApi.Models.Plan", b =>
                {
                    b.Property<int>("pId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pId"), 1L, 1);

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pId");

                    b.ToTable("plans");

                    b.HasData(
                        new
                        {
                            pId = 1,
                            Amount = "1000000",
                            Duration = "1 years",
                            pName = "Jeevan Raksha Yojna"
                        },
                        new
                        {
                            pId = 2,
                            Amount = "200000",
                            Duration = "5 years",
                            pName = "Health Security Plan "
                        });
                });

            modelBuilder.Entity("CMSWebApi.Models.MemberPlan", b =>
                {
                    b.HasOne("CMSWebApi.Models.Claim", "Claims")
                        .WithMany("MemberPlans")
                        .HasForeignKey("CId");

                    b.HasOne("CMSWebApi.Models.Member", "Member")
                        .WithMany("MemberPlans")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMSWebApi.Models.Plan", "Plan")
                        .WithMany("MemberPlans")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claims");

                    b.Navigation("Member");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("CMSWebApi.Models.Claim", b =>
                {
                    b.Navigation("MemberPlans");
                });

            modelBuilder.Entity("CMSWebApi.Models.Member", b =>
                {
                    b.Navigation("MemberPlans");
                });

            modelBuilder.Entity("CMSWebApi.Models.Plan", b =>
                {
                    b.Navigation("MemberPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
