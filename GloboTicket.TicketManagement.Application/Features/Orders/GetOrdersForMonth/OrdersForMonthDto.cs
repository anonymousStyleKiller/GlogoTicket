using System;

namespace GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth
{
    public abstract class OrdersForMonthDto
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}