using System;

namespace Queues.API.DTOs
{
    public class QueueMessageOutputModel
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
    }
}
