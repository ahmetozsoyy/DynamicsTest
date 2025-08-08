using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace DynamicsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"
        AuthType=ClientSecret;
        Url=https://orgb969943d.crm4.dynamics.com;
        ClientId=e3ab02fc-f225-40e2-b71b-4b08c8574500;
        ClientSecret=wbZ8Q~Y4SXQiNIxbiyNWYA2WWRDYCQZ3X1G6ucVE;
        TenantId=4b55b462-e98f-4bba-a0b1-9d792ff93016;
";
            using (var serviceClient = new ServiceClient(connectionString))
            {
                if (serviceClient.IsReady)
                {
                    Console.WriteLine("Bağlantı başarılı.");
                }
                else
                {
                    Console.WriteLine("Bağlantı başarısız.");
                    Console.WriteLine(serviceClient.LastError); 
                }
            }
        }
    }
}
