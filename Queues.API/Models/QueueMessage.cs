using System;

namespace Queues.API.Models
{
    public class QueueMessage
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Ttl { get; set; }
        public string Payload { get; set; }

        public Queue Queue { get; set; }
    }
}
