using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Helper;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(750);
            server.Run();
            Console.ReadKey();
        }
    }
}
