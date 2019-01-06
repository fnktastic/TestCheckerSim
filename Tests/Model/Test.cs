using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests.Enum;
using Tests.Helper;
using Tests.Interface;

namespace Tests.Model
{
    public abstract class Test
    {
        protected string _name;
        protected PriorityEnum _priority;
        protected bool? _isSuccessful = null;
        protected int _takenTime;
    }

    public class FunctionalTest : Test, ITest
    {
        public FunctionalTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class PerformanceTest : Test, ITest
    {
        public PerformanceTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class LoadingTest : Test, ITest
    {
        public LoadingTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class StressTest : Test, ITest
    {
        public StressTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class StableTest : Test, ITest
    {
        public StableTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class ConfigureTest : Test, ITest
    {
        public ConfigureTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class UsabilityTest : Test, ITest
    {
        public UsabilityTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class UITest : Test, ITest
    {
        public UITest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class SecurityTest : Test, ITest
    {
        public SecurityTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
            _takenTime = RandomTestInt.Get();
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class CompatibilityTest : Test, ITest
    {
        public CompatibilityTest(string name, PriorityEnum priority)
        {
            _name = name;
            _priority = priority;
        }

        public void Run()
        {
            _takenTime = RandomTestInt.Get();
            _isSuccessful = RandomTestResult.Get();
        }

        public PriorityEnum GetPriority()
        {
            return _priority;
        }

        public bool? IsSuccessful()
        {
            return _isSuccessful;
        }

        public int GetTakenTime()
        {
            return _takenTime;
        }

        public string GetName()
        {
            return _name;
        }
    }

}