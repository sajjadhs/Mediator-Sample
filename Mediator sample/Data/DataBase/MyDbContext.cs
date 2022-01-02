using Mediator_sample.Domains;
using Microsoft.EntityFrameworkCore;

namespace Mediator_sample.Data.DataBase
{
    public class MyDbContext:DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("In-MemoryDb");
        }
    }
}
