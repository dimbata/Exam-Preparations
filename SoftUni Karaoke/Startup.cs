using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    public class Startup
    {
        public static void Main()
        {
            var awards = new Dictionary<string, List<string>>();
            List<string> participants = Console.ReadLine().Split(new char[] { ' ', ',' }).Where(x => x != string.Empty).ToList();
            List<string> songs = Console.ReadLine().Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            string performance = Console.ReadLine();

            while (performance != "dawn")
            {
                List<string> stagePerformance = performance.Split(new char[] { ',' }).Where(x => x != string.Empty).Select(x => x.Trim()).ToList();
                string performer = stagePerformance[0];
                string song = stagePerformance[1];
                string award = stagePerformance[2];
                if (!songs.Contains(song) || !participants.Contains(performer))
                {
                    performance = Console.ReadLine();
                    continue;
                }
                if (!awards.ContainsKey(performer))
                {
                    awards.Add(performer, new List<string>());
                    awards[performer].Add(award);
                }
                else
                {
                    if (!awards[performer].Contains(award))
                    {
                        awards[performer].Add(award);
                    }
                }
                performance = Console.ReadLine();
            }

            var sorted = awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            if (awards.Count != 0)
            {
                foreach (var contestant in sorted)
                {
                    Console.WriteLine($"{contestant.Key}: {contestant.Value.Count} awards");
                    foreach (var award in contestant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                } 
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
