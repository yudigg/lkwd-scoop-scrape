using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          
             WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com/en-us/library/fhd1f0sw(v=vs.110).aspx");

            Console.WriteLine(reply);
            Console.ReadKey(true);
        }
      
    }
}
