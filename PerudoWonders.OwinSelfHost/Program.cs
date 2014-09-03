using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PerudoWonders.OwinSelfHost
{
    public class Program
    {
        private static Process _mongodProcess = new Process();

        static void Main()
        {
            _mongodProcess = Process.Start(@"C:\Program Files\MongoDB 2.6 Standard\bin\mongod.exe", @"--dbpath C:\PerudoData\db");
            string baseAddress = "http://localhost:9000/";
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                //HttpClient client = new HttpClient();

                //var response = client.GetAsync(baseAddress + "api/values").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Self hosted Perudo Wonders started at " + baseAddress);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            _mongodProcess.Kill();
        }
    } 
}
