using Vishnu.Interchange;

namespace ConsoleLoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger.ConsoleLogger cl = new();
            cl.Log(null, new TreeParameters("MainTree", null), new TreeEvent("EventName", "SourceId", "SenderId", "NodeName", "NodePath", true, NodeLogicalState.Done, null, null), null);
            Console.WriteLine("Ende mit Enter");
            Console.ReadLine();
        }
    }
}