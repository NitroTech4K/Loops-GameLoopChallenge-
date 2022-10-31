using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loops_GameLoopChallenge_
{
    internal class Program
    {

        static int x;
        static int y;

        static bool gameOver;

        static void Main(string[] args)
        {

            gameOver = false;


            //Spawn here
            x = 50;
            y = 10;

            PlayerDraw();

            Console.ReadKey(true);
            
            
            while (gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw();
            }


        }




        static void PlayerUpdate()
        {
            //"ConsoleKeyInfo" is all the values of the keys. We make a new variable called "inputKey" that's right next to "ConsoleKeyInfo because we're making a new variable with that name. 

            //inputKey = Console.ReadKey(true) is saying to put the pressed key into the inputKey variable as its value. So you have to press a button to continue, and returns a key value.

            ConsoleKeyInfo inputKey;
            inputKey = Console.ReadKey(true);
            if(inputKey.Key == ConsoleKey.W)
            {
                y = y - 1;
            }

            else if(inputKey.Key == ConsoleKey.A)
            {
                x = x - 5;
            }

            else if (inputKey.Key == ConsoleKey.S)
            {
                y = y +1;
            }

            else if (inputKey.Key == ConsoleKey.D)
            {
                x = x + 5;
            }

            else if (inputKey.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
        }







        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("(^_^)");
        }


    }
}
