using Mediator_sample.Domains;
using MediatR;

namespace Mediator_sample.Mediator.Commands
{
    public class DeleteMessageCommand : IRequest<Message>
    {
        public int Id { get; set; }
    }
}
