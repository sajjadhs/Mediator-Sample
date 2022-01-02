using Mediator_sample.Data.DataBase;
using Mediator_sample.Data.Services.Contract;
using Mediator_sample.Domains;

namespace Mediator_sample.Data.Services.Concrete
{
    public class MessageService : BaseService<Message, int>, IMessageService
    {
        public MessageService(MyDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
