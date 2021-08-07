﻿// <auto-generated />
using System;
using GloboTicket.TicketManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    [DbContext(typeof(GloboTicketDbContext))]
    partial class GloboTicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GloboTicket.TicketManagement.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("8c75c1d9-9cb2-471d-b070-dfe51e64bfef"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Concerts"
                        },
                        new
                        {
                            CategoryId = new Guid("265fc0e1-a6e0-4e8c-a7a0-69a40d90397e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Musicals"
                        },
                        new
                        {
                            CategoryId = new Guid("fea0cc6f-18fe-47a8-a1d1-9d7a879861ec"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Plays"
                        },
                        new
                        {
                            CategoryId = new Guid("baf50fd4-7e94-474a-96c9-754ab1399c79"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Conferences"
                        });
                });

            modelBuilder.Entity("GloboTicket.TicketManagement.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("0278b527-42cf-49a8-aca3-98143880aec7"),
                            Artist = "Моргенштерн",
                            CategoryId = new Guid("8c75c1d9-9cb2-471d-b070-dfe51e64bfef"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 2, 6, 16, 43, 4, 349, DateTimeKind.Local).AddTicks(3895),
                            Description = "Моргенште́рн (настоящее имя — Алише́р Таги́рович Моргенште́рн, урожд. — Вале́ев[комм 2]; род. 17 февраля 1998, Уфа) — российский рэп-исполнитель и музыкант. Ранее вёл активную видеоблогерскую деятельность на видеохостинге YouTube.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg/274px-Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg",
                            Name = "Алише́р Таги́рович Моргенште́рн",
                            Price = 80
                        },
                        new
                        {
                            EventId = new Guid("0278b527-42cf-49a8-aca3-98143880aec3"),
                            Artist = "Скриптонит",
                            CategoryId = new Guid("265fc0e1-a6e0-4e8c-a7a0-69a40d90397e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2021, 12, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(5071),
                            Description = "Скриптони́т (англ. Scriptonite) — казахстанский исполнитель и музыкальный продюсер, основатель лейбла Musica36[10].",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Scriptonite.jpg/300px-Scriptonite.jpg",
                            Name = "Ади́ль Оралбе́кович Жале́лов",
                            Price = 65
                        },
                        new
                        {
                            EventId = new Guid("0278b527-42cf-49a8-aca3-98143880aec4"),
                            Artist = "Oxxxymiron",
                            CategoryId = new Guid("fea0cc6f-18fe-47a8-a1d1-9d7a879861ec"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 4, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(5119),
                            Description = "Oxxxymiron (Оксимиро́н; настоящее имя — Миро́н Я́нович Фёдоров (англ. Miron Yanovich Fyodorov); род. 31 января 1985 года, Ленинград, РСФСР, СССР) — российский хип-хоп-исполнитель и бывший исполнительный директор букинг-агентства Booking Machine",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Oxxxymiron._Reebok.png/250px-Oxxxymiron._Reebok.png",
                            Name = "Миро́н Я́нович Фёдоров",
                            Price = 70
                        });
                });

            modelBuilder.Entity("GloboTicket.TicketManagement.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(6545),
                            OrderTotal = 400,
                            UserId = new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b")
                        },
                        new
                        {
                            Id = new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(7346),
                            OrderTotal = 135,
                            UserId = new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340")
                        },
                        new
                        {
                            Id = new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(7375),
                            OrderTotal = 85,
                            UserId = new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c")
                        });
                });

            modelBuilder.Entity("GloboTicket.TicketManagement.Domain.Entities.Event", b =>
                {
                    b.HasOne("GloboTicket.TicketManagement.Domain.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
