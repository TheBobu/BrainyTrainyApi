﻿// <auto-generated />
using System;
using BrainyTrainy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrainyTrainy.Data.Migrations
{
    [DbContext(typeof(BrainyTrainyContext))]
    partial class BrainyTrainyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Math"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Quiz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 4,
                            Name = "FillTheGaps"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Matching"
                        });
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.GameHistory", b =>
                {
                    b.Property<int>("GameHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeCompleted")
                        .HasColumnType("time");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GameHistoryId");

                    b.HasIndex("UserId");

                    b.ToTable("GameHistories");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.GameProgress", b =>
                {
                    b.Property<int>("GameProgressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AverageScore")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("AverageTime")
                        .HasColumnType("time");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("GameId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Week")
                        .HasColumnType("datetime2");

                    b.HasKey("GameProgressId");

                    b.HasIndex("GameId1");

                    b.HasIndex("UserId");

                    b.ToTable("GameProgresses");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.PersonInfo", b =>
                {
                    b.Property<int>("PersonInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonInfoId");

                    b.ToTable("PersonInfos");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("InfoId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("InfoId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.GameHistory", b =>
                {
                    b.HasOne("BrainyTrainy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.GameProgress", b =>
                {
                    b.HasOne("BrainyTrainy.Domain.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId1");

                    b.HasOne("BrainyTrainy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BrainyTrainy.Domain.Entities.User", b =>
                {
                    b.HasOne("BrainyTrainy.Domain.Entities.PersonInfo", "Info")
                        .WithMany()
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Info");
                });
#pragma warning restore 612, 618
        }
    }
}
