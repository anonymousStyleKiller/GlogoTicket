using GloboTicket.TicketManagement.Application.Responses;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base() { }
        public CreateCategoryDto Category { get; set; }
    }
}