using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _asyncRepository;
        private readonly IMapper _mapper;
        
        public DeleteEventCommandHandler(IMapper mapper, IAsyncRepository<Event> asyncRepository)
        {
            _mapper = mapper;
            _asyncRepository = asyncRepository;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            if (!(await _asyncRepository.GetByIdAsync(request.EventId) is { } eventToDelete))
                throw new NotFoundException(nameof(Event), request.EventId);
            
            await _asyncRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}