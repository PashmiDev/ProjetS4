using System;
using IDeviceLib;
using TestDevice.Interfaces;

namespace TestDevices
{
    public class RandomScannerDevice : IScannerWithParameter
    {
        public IPeripheralEventHandler eventHandler {get; set;}
        void IDevice.Start()
        {
            System.Console.WriteLine("[Start] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("start", "startEvent", "100");
            System.Console.WriteLine("Event added!");

        }

        void IDevice.Stop()
        {
            System.Console.WriteLine("[Stop] Event preparing...");
            this.eventHandler.putPeripheralEventInQueue("stop", "stopEvent", "101");
            System.Console.WriteLine("Event added!");

        }

        void IScanner.Scan()
        {
            System.Console.WriteLine("[Scan] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("scan", "scanEvent", "102");
            System.Console.WriteLine("[Scan] Event added to queue");
        }

        void IScanner.Foo()
        {
            System.Console.WriteLine("[Foo] Event preparing");
            this.eventHandler.putPeripheralEventInQueue("Foo", "FooEvent", "103");
            System.Console.WriteLine("[Foo] Event added to queue");
        }

        public void printTest(string parameterTest)
        {
            System.Console.WriteLine("[printTest] Event preparing" + parameterTest);
            this.eventHandler.putPeripheralEventInQueue("printTest", "printTest", "printTest");
            System.Console.WriteLine("[printTest] Event added to queue"); 
        }
    }
}