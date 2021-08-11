using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth
{
    public class PageOrdersForMonthVm
    {
        public int Count { get; set; }
        public List<OrdersForMonthDto> OrdersForMonth { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}