using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Enum;
using Tests.Interface;
using Tests.Model;

namespace Tests.Helper
{
    public class Server
    {
        private int _testsCount;
        private Task _testWorker;
        private ITest _test;
        private bool _sendToClient = false;
        private TestResult testResult;
        private TcpSender tcpSender = new TcpSender();

        public Server(int testsCount)
        {
            if (_sendToClient)
                tcpSender.Connect();

            _testsCount = testsCount;
            _testWorker = new Task(() =>
            {
                for (int i = 0; i < _testsCount; i++)
                {
                    _test = GetTest();
                    WriteDetails(_test);
                }
            });
        }

        public void Run()
        {
            _testWorker.Start();
        }

        private ITest GetTest()
        {
            ITest test = null;
            TestTypeEnum testType = (TestTypeEnum)RandomTestInt.Get(0, 9);
            PriorityEnum priority = (PriorityEnum)RandomTestInt.Get(0, 5);
            switch (testType)
            {
                case TestTypeEnum.FunctionalTest:
                    test = new FunctionalTest("FunctionalTest", priority);
                    break;
                case TestTypeEnum.PerformanceTest:
                    test = new PerformanceTest("PerformanceTest", priority);
                    break;
                case TestTypeEnum.LoadingTest:
                    test = new LoadingTest("LoadingTest", priority);
                    break;
                case TestTypeEnum.StressTest:
                    test = new StressTest("StressTest", priority);
                    break;
                case TestTypeEnum.StableTest:
                    test = new StableTest("StableTest", priority);
                    break;
                case TestTypeEnum.ConfigureTest:
                    test = new ConfigureTest("ConfigureTest", priority);
                    break;
                case TestTypeEnum.UsabilityTest:
                    test = new UsabilityTest("UsabilityTest", priority);
                    break;
                case TestTypeEnum.UITest:
                    test = new UITest("UITest", priority);
                    break;
                case TestTypeEnum.SecurityTest:
                    test = new SecurityTest("SecurityTest", priority);
                    break;
                case TestTypeEnum.CompatibilityTest:
                    test = new CompatibilityTest("CompatibilityTest", priority);
                    break;
            }

            return test;
        }

        private void WriteDetails(ITest test)
        {
            if (_sendToClient)
                tcpSender.Send("!START!");

            try
            {
                Console.WriteLine("Test '{0}' is running...", _test.GetName());
                testResult = TestResult.Map(_test);

                if (_sendToClient)
                    tcpSender.Send(TestNameToSend(testResult));

                _test.Run();
                _testWorker.Wait(_test.GetTakenTime());
                Console.WriteLine("Test {0}", _test.IsSuccessful() == true ? "PASSED" : "FAILED");
                Console.WriteLine("Priority - {0}", _test.GetPriority());
                Console.WriteLine("Taken Time - {0} milliseconds", _test.GetTakenTime());
                Console.WriteLine("---------------------------------------");

                if (_sendToClient)
                    tcpSender.Send(FullTestToSend(testResult));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private string TestNameToSend(TestResult testResult)
        {
            return string.Format("@1@{0}", testResult.Name);
        }

        private string FullTestToSend(TestResult testResult)
        {
            return string.Format("@2@{0}", testResult.ToString());
        }
    }
}
