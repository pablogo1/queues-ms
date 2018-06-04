using System.Collections.Generic;

namespace Queues.API.Models
{
    public class Queue
    {
        public string Name { get; set; }
        public int DefaultTtl { get; set; }

        public ICollection<QueueMessage> QueueMessages { get; set; }
    }
}
