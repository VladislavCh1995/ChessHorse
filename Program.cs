using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            //if (x2 != x1 && x2 <= (x1 + 2) && x2 > (x1 - 2))
            //{
                int spaceX = Math.Abs(x2 - x1);
                int spaceY = Math.Abs(y2 - y1);
                if ((spaceX == 2 && spaceY == 1) || (spaceX == 1 && spaceY == 2))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            //}
            //else
           // {
           //     Console.WriteLine("NO");
           // }
        }
    }
}
