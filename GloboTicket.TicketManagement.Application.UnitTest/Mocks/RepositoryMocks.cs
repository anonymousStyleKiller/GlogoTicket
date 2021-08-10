using System;
using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Moq;

namespace GloboTicket.TicketManagement.Application.UnitTest.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IAsyncRepository<Category>> GetCategoryRepository()
        {
            var concertGuid = Guid.Parse("{8C75C1D9-9CB2-471D-B070-DFE51E64BFEF}");
            var musicalGuid = Guid.Parse("{265FC0E1-A6E0-4E8C-A7A0-69A40D90397E}");
            var playGuid = Guid.Parse("{FEA0CC6F-18FE-47A8-A1D1-9D7A879861EC}");
            var conferenceGuid = Guid.Parse("{BAF50FD4-7E94-474A-96C9-754AB1399C79}");

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = concertGuid,
                    Name = "Concerts"
                },
                new Category
                {
                    CategoryId = musicalGuid,
                    Name = "Musicals"
                },
                new Category
                {
                    CategoryId = conferenceGuid,
                    Name = "Conferences"
                },
                new Category
                {
                    CategoryId = playGuid,
                    Name = "Plays"
                }
            };
            
            var mockCategoryRepository = new Mock<IAsyncRepository<Category>>();
            mockCategoryRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(categories);

            mockCategoryRepository.Setup(repo => repo.AddAsync(It.IsAny<Category>()))
                .ReturnsAsync((Category category) =>
                {
                    categories.Add(category);
                    return category;
                });
            return mockCategoryRepository;
        }
    }
}