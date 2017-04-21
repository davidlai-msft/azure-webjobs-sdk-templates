using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace Company.Function
{
    public static class ServiceBusQueueTriggerCSharp
    {
        [FunctionName("%FunctionName%")]                    
        public static void Run([ServiceBusTrigger("%QueueName%", AccessRights.%AccessRights%, Connection = "%Connection%")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}