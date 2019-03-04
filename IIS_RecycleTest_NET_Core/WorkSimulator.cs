using System.IO;
using System.Threading.Tasks;

namespace IIS_RecycleTest_NET_Core
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