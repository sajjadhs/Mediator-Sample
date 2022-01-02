using Mediator_sample.Domains;
using MediatR;

namespace Mediator_sample.Mediator.Queries
{
    public class GetMessageListQuery : IRequest<IList<Message>>
    {

    }
}
