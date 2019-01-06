using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Enum;

namespace Tests.Interface
{
    public interface ITest
    {
        void Run();
        bool? IsSuccessful();
        PriorityEnum GetPriority();
        int GetTakenTime();
        string GetName();
    }
}
