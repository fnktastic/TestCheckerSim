using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Interface;

namespace Tests.Model
{
    public class TestResult
    {
        public string Name { get; set; }
        public string TakenTime { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        public static TestResult Map(ITest test)
        {
            string name = test.GetName();
            string takenTime = test.GetTakenTime().ToString();
            string priority = test.GetPriority().ToString();
            string status = test.IsSuccessful() == true ? "PASSED" : "FAILED";
            return new TestResult()
            {
                Name = name,
                TakenTime = takenTime,
                Priority = priority, 
                Status = status
            };
        }

        public override string ToString()
        {
            return string.Format("{0}#{1}#{2}#{3}", Name, TakenTime, Priority, Status);
        }
    }
}
