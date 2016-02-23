using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibraryChannelFactory;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CustomersService)))
            {
                var EndPoint = host.AddServiceEndpoint(
                    typeof(ICustomersService), 
                    new NetTcpBinding(),
                    "net.tcp://localhost:9000/WcfServiceLibraryChannelFactory/CustomersService");

                    // Start Listening for messages
                host.Open();

                // Consdole.WriteLine("The Service is Running.");
                Console.WriteLine("The service is running and is listening on:");
                Console.WriteLine("{0} ({1})", EndPoint.Address.ToString(), EndPoint.Binding.Name);

                Console.WriteLine();
                Console.WriteLine("Press any key to stop the service.");
                Console.ReadKey();

                host.Close();
                
            }
        }
    }
}
