using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Company.Function
{
    public static class QueueTriggerCSharp
    {
        [FunctionName("%FunctionName%")]        
        public static void Run([QueueTrigger("%Path%", Connection = "%Connection%")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
