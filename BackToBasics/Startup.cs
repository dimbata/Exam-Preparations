using System;
using System.Linq;

namespace ProgrammingFundamentals
{
    public class Startup
    {
        public static void Main()
        {
            int[] times = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            DateTime theDate = new DateTime(1, 1, 1, times[0], times[1], times[2]);
            long steps = long.Parse(Console.ReadLine()) % 86400;
            long timeForStep = long.Parse(Console.ReadLine()) % 86400;
            double totalSeconds = steps * timeForStep;
            theDate = theDate.AddSeconds(totalSeconds);
            Console.WriteLine($"Time Arrival: {theDate.Hour:D2}:{theDate.Minute:D2}:{theDate.Second:D2}");
        }

    }

}