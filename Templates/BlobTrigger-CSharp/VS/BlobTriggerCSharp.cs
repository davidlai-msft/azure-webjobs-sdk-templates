using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Company.Function
{
    public static class BlobTriggerCSharp
    {
        [FunctionName("%FunctionName%")]   
        //[StorageAccount("ConnectionName")]   
        public static void Run([BlobTrigger("samples-workitems/{name}", Connection = "")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}