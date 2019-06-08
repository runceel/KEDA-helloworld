using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionKubernatesHelloWorld
{
    public static class SampleFunction
    {
        [FunctionName("SampleFunction")]
        public static async Task Run([QueueTrigger("dotnet-queue-items")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            await Task.Delay(5000);
        }
    }
}
