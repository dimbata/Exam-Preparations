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
            List<string> participants = Console.ReadLine().Split(new char[] { ' ', ',' }).ToList();
        }
    }
}
