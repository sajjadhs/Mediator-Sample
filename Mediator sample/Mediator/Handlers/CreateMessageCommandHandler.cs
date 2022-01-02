using Mediator_sample.Data.Services;
using Mediator_sample.Data.Services.Contract;
using Mediator_sample.Domains;
using Mediator_sample.Mediator.Commands;
using MediatR;

namespace Mediator_sample.Mediator.Handlers
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Message>
    {
        private readonly IMessageService messageService;
        public CreateMessageCommandHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public async Task<Message> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            return await messageService.AddAsync(request.Message, cancellationToken);
        }
    }
}
