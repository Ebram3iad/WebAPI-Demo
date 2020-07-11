using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWinSelfHostingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WebApp.Start<Startup1>("http://localhost:8080/"))
            {
                Console.WriteLine(" API Hosted http://localhost:8080/ ");
                Console.WriteLine("Press any key to End hosting ");

                Console.ReadKey();
            }
        }
    }
}
