using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
             int attempts = 0;
                Random random = new Random();

                int[] targetNumber = new int[4];

                for (int i = 0; i < targetNumber.Length; i++)

                {

                    if (i == 0)

                    {

                        targetNumber[i] = random.Next(1, 10); 
                    }

                    else

                    {

                        targetNumber[i] = random.Next(0, 10);

                    }

                }



                bool gameOver = false;

                while (!gameOver)

                {

                    Console.WriteLine ("Enter your guess (a 4-digit number): ");

                    int guess = 0;


                  
                    int input = Console.ReadLine();
                   

                    attempts= attempts + 1;
                  

                    if (input.Length != 4)

                    {

                        Console.WriteLine("Invalid input. Please enter a 4-digit number.");

                        ;

                    }




                    int i = 0;

                    {

                        Console.WriteLine("Invalid input. Digits should not repeat.");

                        ;

                    }




                    int bulls = 0;

                    int cows = 0;
                    
                    for ( i = 0; i < targetNumber.Length; i++)

                    {

                        if (guess[i] == targetNumber[i])

                        {

                            bulls = bulls + 1;

                        }

                        else if (targetNumber.Contains(guess[i]))

                        {

                            cows = cows + 1;

                        }

                    }




                    if (bulls == 4)

                    {

                        Console.WriteLine(" You've guessed the number correctly.");
                        Console.WriteLine("It took you " + attempts + " attempts");
                        gameOver = true;

                    }
                    else
                    {
                        Console.WriteLine(+ cows +   "  Cows " + bulls + " Bulls ");
        }
    }
}

