using Mediator_sample.Data.Services;
using Mediator_sample.Data.Services.Contract;
using Mediator_sample.Domains;
using Mediator_sample.Mediator.Commands;
using Mediator_sample.Mediator.Queries;
using MediatR;

namespace Mediator_sample.Mediator.Handlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, Message>
    {
        private readonly IMessageService messageService;
        public GetMessageQueryHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public async Task<Message> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            return await messageService.GetByIdAsync(request.ID);
        }
    }
}
