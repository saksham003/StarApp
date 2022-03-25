﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StarApp.Infrastructure.Data;

#nullable disable

namespace StarApp.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220325055306_PostgresInitial")]
    partial class PostgresInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StarApp.Core.Domain.Entities.Allowance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AfternoonShiftDays")
                        .HasColumnType("integer");

                    b.Property<int?>("CompensationId")
                        .HasColumnType("integer");

                    b.Property<int>("DaysEligibleForTA")
                        .HasColumnType("integer");

                    b.Property<int>("HolidayHours")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NightShiftDays")
                        .HasColumnType("integer");

                    b.Property<string>("PeriodEnd")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PeriodStart")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProjectHours")
                        .HasColumnType("integer");

                    b.Property<string>("SapId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalAllowance")
                        .HasColumnType("integer");

                    b.Property<int>("TransportAllowance")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompensationId");

                    b.ToTable("Allowances");
                });

            modelBuilder.Entity("StarApp.Core.Domain.Entities.Compensation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AfternoonShiftCompensation")
                        .HasColumnType("integer");

                    b.Property<int>("NightShiftCompensation")
                        .HasColumnType("integer");

                    b.Property<int>("TransportCompensation")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Compensations");
                });

            modelBuilder.Entity("StarApp.Core.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ActiveFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("StarApp.Core.Domain.Entities.Allowance", b =>
                {
                    b.HasOne("StarApp.Core.Domain.Entities.Compensation", "Compensation")
                        .WithMany("Allowances")
                        .HasForeignKey("CompensationId");

                    b.Navigation("Compensation");
                });

            modelBuilder.Entity("StarApp.Core.Domain.Entities.Compensation", b =>
                {
                    b.Navigation("Allowances");
                });
#pragma warning restore 612, 618
        }
    }
}
