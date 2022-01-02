using Mediator_sample.Data.Services.Contract;
using Mediator_sample.Domains;
using Mediator_sample.Mediator.Queries;
using MediatR;

namespace Mediator_sample.Mediator.Handlers
{
    public class GetMessageListQueryHandler : IRequestHandler<GetMessageListQuery,IList<Message>>
    {
        private readonly IMessageService messageService;
        public GetMessageListQueryHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public async Task<IList<Message>> Handle(GetMessageListQuery request, CancellationToken cancellationToken)
        {
            return (IList<Message>)await messageService.GetAllAsync(cancellationToken);
        }
    }
}
