using System;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public abstract class OrderController : ControllerBase
    {
        private readonly  IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/getpageordersformonth", Name = "GetPageOrdersForMonth")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<PageOrdersForMonthVm>> GetPageOrdersForMonth(DateTime date, int page, int size)
        {
            var getPageOrdersForMonth = new GetPageOrdersForMonthQuery { Date = date, Page = page, Size = size };
            var dtos = await _mediator.Send(getPageOrdersForMonth).ConfigureAwait(false);
            return Ok(dtos);
        }
    }
}