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

        static bool gameOver; //gameOver kill screen. True or false.

        static void Main(string[] args)
        {

            gameOver = false;


            //Spawn here
            x = 50;
            y = 10;

            PlayerDraw(); //Player spawns in

            Console.ReadKey(true);
            
            
            while (gameOver == false)
            {
                PlayerUpdate(); 
                PlayerDraw();
            }


        }




        static void PlayerUpdate()
        {
            //"ConsoleKeyInfo" is all the values of the keys on the keyboard. We make a new variable called "inputKey" that's right next to "ConsoleKeyInfo" because we're making a new variable with that name. 

            //inputKey = Console.ReadKey(true) is saying to put the pressed key into the inputKey variable as its value. So you have to press a button to continue, and returns a key value.

            //the ".Key" in "inputKey.Key" Signifies the physical key that was pressed. Almost like "inputKey W" but not to be typed that way. 



             //variable    //Name
            ConsoleKeyInfo inputKey;
            inputKey = Console.ReadKey(true); 
            if(inputKey.Key == ConsoleKey.W || inputKey.Key == ConsoleKey.UpArrow) //ConsoleKey.(key pressed) is the final output in the program. 
            {
                y = y - 1;
            }

            else if(inputKey.Key == ConsoleKey.A || inputKey.Key == ConsoleKey.LeftArrow)
            {
                x = x - 5;
            }

            else if (inputKey.Key == ConsoleKey.S || inputKey.Key == ConsoleKey.DownArrow)
            {
                y = y +1;
            }

            else if (inputKey.Key == ConsoleKey.D || inputKey.Key ==ConsoleKey.RightArrow)
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
            //Console.Clear(); //This is the command to clear the previous action (NO SNAKE GAME)
            Console.SetCursorPosition(x, y); //This is the code to move the player
            Console.WriteLine("(^_^)"); //This is the character
        }


    }
}
