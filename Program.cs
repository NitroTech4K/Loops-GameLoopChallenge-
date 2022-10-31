using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_GameLoopChallenge_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerDraw(50, 10);
            Console.ReadKey(true);
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("(^_^)");
        }
    }
}
