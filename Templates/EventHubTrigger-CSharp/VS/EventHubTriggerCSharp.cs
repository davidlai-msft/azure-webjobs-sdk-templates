using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;


namespace Company.Function
{
    public static class EventHubTriggerCSharp
    {
        [FunctionName("%FunctionName%")]
        public static void Run([EventHubTrigger("%Path%", Connection = "%Connection%")]string myEventHubMessage, TraceWriter log)
        {
            log.Info($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}