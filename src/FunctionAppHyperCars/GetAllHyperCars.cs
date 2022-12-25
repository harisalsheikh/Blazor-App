using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionAppHyperCars
{
    public static class GetAllHyperCars
    {
        [FunctionName("GetAllHyperCars")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [CosmosDB(
            databaseName:"HyperCarDb",
            collectionName:"HyperCars",
            ConnectionStringSetting ="CosmosDbConnectionString",
            Id = "{Query.id}",
            PartitionKey = "{Query.carName}"
            )] HyperCars hyperCars,
            ILogger log)
        {
            if(hyperCars == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(hyperCars);
        }
    }

    public class HyperCars
    {
        public int id { get; set; }
        public string carName { get; set; }
        public string Engine { get; set; }
        public int HorsePower { get; set; }
        public int TopSpeed { get; set; }
        public string Cost { get; set; }

    }
}
