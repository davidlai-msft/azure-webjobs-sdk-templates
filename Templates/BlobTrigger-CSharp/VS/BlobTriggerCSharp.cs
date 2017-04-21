using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Company.Function
{
    public static class BlobTriggerCSharp
    {
        [FunctionName("%FunctionName%")]        
        public static void Run([BlobTrigger("%Path%/{name}", Connection = "%Connection%")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}