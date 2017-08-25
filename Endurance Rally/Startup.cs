using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    public class Startup
    {
        public static void Main()
        {
            List<string> drivers = Console.ReadLine().Split(' ').ToList();
            List<double> zoneFuel = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var driver in drivers)
            {
                int reachedIndex = 0;
                double fuel = driver[0];
                bool hasFuel = true;
                for (int i = 0; i < zoneFuel.Count; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zoneFuel[i];
                    }
                    else
                    {
                        fuel -= zoneFuel[i];
                    }

                    if (fuel <= 0)
                    {
                        hasFuel = false;
                        reachedIndex = i;
                        break;
                    }
                }
                if (hasFuel)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {reachedIndex}");
                }

            }
        }
    }
}
