using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winning_Ticket
{
    public class Startup
    {
        public static void Main()
        {
            List<string> tickets = Console.ReadLine().Split(new char[] { ' ', ',' }).Where(x => x != string.Empty).ToList();
            char[] winningSymbols = new[] { '@', '#', '$', '^' };
            foreach (var ticket in tickets)
            {
                int leftLength = 1;
                int rightLength = 1;
                char leftSymbol = ' ';
                char rightSymbol = ' ';
                int tempLength = 1;

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    
                    if (winningSymbols.Contains(ticket[i]))
                    {
                        leftSymbol = ticket[i];
                        while (i < 9 && ticket[i] == ticket[i + 1])
                        {
                            tempLength++;
                            i++;
                        }
                        if (tempLength > leftLength)
                        {
                            leftLength = tempLength;
                        }
                        tempLength = 1;
                    }
                }
                tempLength = 1;
                for (int i = 10; i < 20; i++)
                {
                    if (winningSymbols.Contains(ticket[i]))
                    {
                        rightSymbol = ticket[i];
                        while (i < 19 && ticket[i] == ticket[i + 1])
                        {
                            tempLength++;
                            i++;
                        }
                        
                        if (tempLength > rightLength)
                        {
                            rightLength = tempLength;
                        }
                        tempLength = 1;
                    }
                }

                if (rightSymbol==leftSymbol && rightLength + leftLength == 20)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{rightSymbol} Jackpot!");
                }
                else if ((rightSymbol == leftSymbol && rightLength > 5 && leftLength > 5))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftLength,rightLength)}{rightSymbol}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}

