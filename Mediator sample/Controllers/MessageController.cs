using Mediator_sample.Domains;
using Mediator_sample.Mediator.Commands;
using Mediator_sample.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMediator mediator;

        public MessageController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<Message>> GetAll() => await mediator.Send(new GetMessageListQuery());

        [HttpGet("{Id}")]
        public async Task<Message> Get(int Id) => await mediator.Send(new GetMessageQuery(Id));

        [HttpDelete("{Id}")]
        public async Task<Message> Delete(int Id) => await mediator.Send(new DeleteMessageCommand() { Id=Id });

        [HttpPost]
        public async Task<Message> Add([FromBody]Message message) => await mediator.Send(new CreateMessageCommand(message));


    }
}
