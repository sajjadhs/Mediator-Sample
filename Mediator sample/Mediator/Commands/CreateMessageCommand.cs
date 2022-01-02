using Mediator_sample.Domains;
using MediatR;

namespace Mediator_sample.Mediator.Commands
{
    //public class CreateMessageCommand : IRequest<Message>
    //{
    //    public Message Message { get; set; }
    //}

    public record CreateMessageCommand(Message Message):IRequest<Message>;
}
