using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IAsyncRepository<Event> _asyncRepository;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IAsyncRepository<Event> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _asyncRepository.GetByIdAsync(request.EventId);
            if (eventToUpdate is null) throw new NotFoundException(nameof(Event), request.EventId);
            
            var validator = new UpdateEventCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken).ConfigureAwait(false);
            if (validationResult.Errors.Count>0)  throw new ValidationException(validationResult);
           
            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event));
            await _asyncRepository.UpdateAsync(eventToUpdate).ConfigureAwait(false);
           
            return Unit.Value;
        }
    }
}