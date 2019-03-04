using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace IIS_RecycleTest
{
    public class WorkSimulator
    {
        public static async Task SimulateBackgroundTask()
        {
            File.WriteAllText("C:\\temp\\workSimulator.txt", "Work simulator started.");

            await Task.Delay(50000);

            File.WriteAllText("C:\\temp\\workSimulator.txt", "Work simulator ended.");
        }
    }
}