using Queues.API.Models;

namespace Queues.API.DTOs
{
    public static class QueueMessageMappingExtensions
    {
        public static QueueMessageOutputModel ToOutputModel(this QueueMessage queueMessage) => new QueueMessageOutputModel
        {
            Id = queueMessage.Id,
            Payload = queueMessage.Payload
        };

        public static QueueMessage ToModel(this QueueMessageInputModel inputModel) => new QueueMessage
        {
            Payload = inputModel.Payload
        };
    }
}
