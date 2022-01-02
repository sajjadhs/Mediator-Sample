using Mediator_sample.Data.Services.Contract;
using Mediator_sample.Domains;
using Mediator_sample.Mediator.Commands;
using MediatR;

namespace Mediator_sample.Mediator.Handlers
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, Message>
    {
        private readonly IMessageService messageService;
        public DeleteMessageCommandHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public async Task<Message> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            return await messageService.DeleteAsync(request.Id, cancellationToken);
        }
    }
}
