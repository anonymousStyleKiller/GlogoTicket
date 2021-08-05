using System.Collections.Generic;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListVm
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
        
    }
}