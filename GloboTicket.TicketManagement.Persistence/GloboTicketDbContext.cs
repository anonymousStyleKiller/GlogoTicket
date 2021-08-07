using System;
using System.Threading;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Common;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence
{
    public class GloboTicketDbContext : DbContext
    {
        public GloboTicketDbContext(DbContextOptions<GloboTicketDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GloboTicketDbContext).Assembly);

            var concertGuid = Guid.Parse("{8C75C1D9-9CB2-471D-B070-DFE51E64BFEF}");
            var musicalGuid = Guid.Parse("{265FC0E1-A6E0-4E8C-A7A0-69A40D90397E}");
            var playGuid = Guid.Parse("{FEA0CC6F-18FE-47A8-A1D1-9D7A879861EC}");
            var conferenceGuid = Guid.Parse("{BAF50FD4-7E94-474A-96C9-754AB1399C79}");

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = concertGuid,
                Name = "Concerts"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = musicalGuid,
                Name = "Musicals"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = playGuid,
                Name = "Plays"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = conferenceGuid,
                Name = "Conferences"
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{0278B527-42CF-49A8-ACA3-98143880AEC7}"),
                Name = "Алише́р Таги́рович Моргенште́рн",
                Price = 80,
                Artist = "Моргенштерн",
                Date = DateTime.Now.AddMonths(6),
                Description =
                    "Моргенште́рн (настоящее имя — Алише́р Таги́рович Моргенште́рн, урожд. — Вале́ев[комм 2]; род. 17 февраля 1998, Уфа) — российский рэп-исполнитель и музыкант. Ранее вёл активную видеоблогерскую деятельность на видеохостинге YouTube.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg/274px-Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg",
                CategoryId = concertGuid
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{0278B527-42CF-49A8-ACA3-98143880AEC3}"),
                Name = "Ади́ль Оралбе́кович Жале́лов",
                Price = 65,
                Artist = "Скриптонит",
                Date = DateTime.Now.AddMonths(4),
                Description =
                    "Скриптони́т (англ. Scriptonite) — казахстанский исполнитель и музыкальный продюсер, основатель лейбла Musica36[10].",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Scriptonite.jpg/300px-Scriptonite.jpg",
                CategoryId = musicalGuid
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{0278B527-42CF-49A8-ACA3-98143880AEC4}"),
                Name = "Миро́н Я́нович Фёдоров",
                Price = 70,
                Artist = "Oxxxymiron",
                Date = DateTime.Now.AddMonths(8),
                Description =
                    "Oxxxymiron (Оксимиро́н; настоящее имя — Миро́н Я́нович Фёдоров (англ. Miron Yanovich Fyodorov); род. 31 января 1985 года, Ленинград, РСФСР, СССР) — российский хип-хоп-исполнитель и бывший исполнительный директор букинг-агентства Booking Machine",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Oxxxymiron._Reebok.png/250px-Oxxxymiron._Reebok.png",
                CategoryId = playGuid
            });


            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{7E94BC5B-71A5-4C8C-BC3B-71BB7976237E}"),
                OrderTotal = 400,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserId = Guid.Parse("{A441EB40-9636-4EE6-BE49-A66C5EC1330B}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{86D3A045-B42D-4854-8150-D6A374948B6E}"),
                OrderTotal = 135,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserId = Guid.Parse("{AC3CFAF5-34FD-4E4D-BC04-AD1083DDC340}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{771CCA4B-066C-4AC7-B3DF-4D12837FE7E0}"),
                OrderTotal = 85,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserId = Guid.Parse("{D97A15FC-0D32-41C6-9DDF-62F0735C4C1C}")
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}