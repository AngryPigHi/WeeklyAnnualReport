﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetapp;

#nullable disable

namespace aspnetapp.Migrations
{
    [DbContext(typeof(AnnualContext))]
    partial class AnnualContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8_general_ci")
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8");

            modelBuilder.Entity("aspnetapp.Counter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("Counters", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.AnnualKeyWords", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<int>("KeyWeight")
                        .HasColumnType("int");

                    b.Property<string>("KeyWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_AnnualKeyWords", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.LeaderSaying", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LeaderId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LeaderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("LeaderOrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LeaderOrganizationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LeaderRole")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Saying")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_LeaderSayings", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.NewYearLuckyTips", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<string>("LuckyContent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LuckyTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NewYear")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_NewYearLuckyTips", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.ProjectHourReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<double>("HourRate")
                        .HasColumnType("double");

                    b.Property<string>("ProjectNameWithManager")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<double>("WorkHours")
                        .HasColumnType("double");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_ProjectHourReports", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("FirstReportDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Organization")
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("T_UserInfos", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.WorkHourReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double>("AverageHours")
                        .HasColumnType("double");

                    b.Property<int>("DaysOver8Hours")
                        .HasColumnType("int");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<int>("ReportCount")
                        .HasColumnType("int");

                    b.Property<double>("ReportTotalTime")
                        .HasColumnType("double");

                    b.Property<DateTime?>("SpecialDayDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("SpecialDayHours")
                        .HasColumnType("double");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_WorkHourReports", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.WorkPlaceReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<double>("HourRate")
                        .HasColumnType("double");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<double>("WorkHours")
                        .HasColumnType("double");

                    b.Property<string>("WorkPlace")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_WorkPlaceReports", (string)null);
                });

            modelBuilder.Entity("aspnetapp.Models.EntityModels.WorkTypeReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Domain")
                        .HasColumnType("char(36)");

                    b.Property<double>("HourRate")
                        .HasColumnType("double");

                    b.Property<string>("PMOWorkType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<double>("WorkHours")
                        .HasColumnType("double");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_WorkTypeReports", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
