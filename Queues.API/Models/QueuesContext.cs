using Microsoft.EntityFrameworkCore;

namespace Queues.API.Models
{
    public class QueuesContext : DbContext
    {
        public QueuesContext(DbContextOptions<QueuesContext> options)
            : base(options)
        {

        }

        public DbSet<Queue> Queues { get; set; }

    }
}
