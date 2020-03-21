using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace AppMicrosoftInicio
{
    public class Program
    {
        private static RestClient client = new RestClient("https://dev.azure.com/fabrikam/_apis/wit/attachments/{id}?api-version=5.1");
        public static void Main(string[] args)
        {
            
            CreateWebHostBuilder(args).Build().Run();
            RestRequest request = new RestRequest("Default", Method.GET);
            IRestResponse<List<string>> response =
            client.Execute<List<string>>(request);
            Console.ReadKey();

        }
       
           
        

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
