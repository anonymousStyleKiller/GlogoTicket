using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory
{
    public abstract class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}