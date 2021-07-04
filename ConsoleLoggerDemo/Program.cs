using System;
using Vishnu.Interchange;

namespace ConsoleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger cl = new ConsoleLogger();
            cl.Log(null, new TreeParameters("MainTree", null), new TreeEvent("EventName", "SourceId", "SenderId", "NodeName", "NodePath", true, NodeLogicalState.Done, null, null), null);
            Console.WriteLine("Ende mit Enter");
            Console.ReadLine();
        }
    }
}
