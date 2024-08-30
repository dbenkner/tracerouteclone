using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tracerouteclone
{
    public class Start
    {
        public static void Main(string[] Args) {
            string url = Args[0];
            string ip = Dns.GetHostAddresses(url).FirstOrDefault().ToString();
            Console.WriteLine($"Tracing Route to {url} ({ip}), 64 hops max, 32 byte packets");
        }
    }
}
