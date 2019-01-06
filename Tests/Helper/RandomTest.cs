using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Helper
{
    public static class RandomTestResult
    {
        public static bool Get()
        {
            Random random = new Random();
            bool result = random.Next(0, 2) > 0;
            return result;
        }
    }

    public static class RandomTestInt
    {
        public static int Get()
        {
            Random random = new Random();
            int delay = random.Next(100, 10000);
            return delay;
        }

        public static int Get(int min, int max)
        {
            Random random = new Random();
            int delay = random.Next(min, max);
            return delay;
        }
    }
}
