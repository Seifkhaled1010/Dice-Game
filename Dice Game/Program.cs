using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myDice;
            int enemyDice;

            int myPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                myDice = random.Next(1, 7);
                Console.WriteLine("You rolled a " + myDice);

                Console.WriteLine("---------------------------------");
                System.Threading.Thread.Sleep(1000);

                enemyDice = random.Next(1, 7);
                Console.WriteLine("enemy rolled a " + enemyDice);
                Console.WriteLine("***************************");

                if (myDice > enemyDice)
                {
                    myPoints++;
                    Console.WriteLine("The winner of rounde is me! :)");
                }
                else if (myDice < enemyDice)
                {
                    enemyPoints++;
                    Console.WriteLine("The winner of round is enemy! :(");
                }
                else
                    Console.WriteLine("Draw!");

                Console.WriteLine("Current score is - My score: " + myPoints + ". Enemy score: " + enemyPoints + ".");
                Console.WriteLine();

            }

            if(myPoints > enemyPoints)
            {
                Console.WriteLine("You are the winner *************");
            }
            else if(enemyPoints > myPoints)
            {
                Console.WriteLine("You lose *__*");
            }
            else
            
                Console.WriteLine("It's a draw match");
            
            Console.ReadKey();
        }
    }
}
