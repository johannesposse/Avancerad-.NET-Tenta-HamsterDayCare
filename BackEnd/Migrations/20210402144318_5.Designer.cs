﻿// <auto-generated />
using System;
using BackEnd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(HamsterDayCareContext))]
    [Migration("20210402144318_5")]
    partial class _5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.ActivityLog", b =>
                {
                    b.Property<int>("ActivityLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HamsterID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityLogID");

                    b.HasIndex("HamsterID");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("BackEnd.Cage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasFemale")
                        .HasColumnType("bit");

                    b.Property<int>("MaxSize")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Cages");
                });

            modelBuilder.Entity("BackEnd.ExerciseArea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasFemale")
                        .HasColumnType("bit");

                    b.Property<int>("MaxSize")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ExerciseArea");
                });

            modelBuilder.Entity("BackEnd.Hamster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CageID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckedInTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExerciseAreaID")
                        .HasColumnType("int");

                    b.Property<bool>("IsFemale")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastExercise")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ownername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CageID");

                    b.HasIndex("ExerciseAreaID");

                    b.ToTable("Hamsters");
                });

            modelBuilder.Entity("BackEnd.ActivityLog", b =>
                {
                    b.HasOne("BackEnd.Hamster", "Hamster")
                        .WithMany()
                        .HasForeignKey("HamsterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hamster");
                });

            modelBuilder.Entity("BackEnd.Hamster", b =>
                {
                    b.HasOne("BackEnd.Cage", "Cage")
                        .WithMany("Hamsters")
                        .HasForeignKey("CageID");

                    b.HasOne("BackEnd.ExerciseArea", "ExerciseArea")
                        .WithMany("Hamsters")
                        .HasForeignKey("ExerciseAreaID");

                    b.Navigation("Cage");

                    b.Navigation("ExerciseArea");
                });

            modelBuilder.Entity("BackEnd.Cage", b =>
                {
                    b.Navigation("Hamsters");
                });

            modelBuilder.Entity("BackEnd.ExerciseArea", b =>
                {
                    b.Navigation("Hamsters");
                });
#pragma warning restore 612, 618
        }
    }
}
