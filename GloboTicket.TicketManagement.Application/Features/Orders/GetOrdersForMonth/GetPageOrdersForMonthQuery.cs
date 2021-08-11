using System;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth
{
    public class GetPageOrdersForMonthQuery : IRequest<PageOrdersForMonthVm>
    {
        public DateTime Date { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}