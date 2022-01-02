using Mediator_sample.Domains;
using MediatR;

namespace Mediator_sample.Mediator.Queries
{
    public record GetMessageQuery(int ID) : IRequest<Message>;
}
