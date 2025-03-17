/*
    * generate a random number between min and max
    * let the user guess the number
    * if the number is too low or high give a hint
    * user can keep guessing
    * count the attempts of user
 */ 
using System;

namespace NumberGuessingGame
{
     class Program
    {
        static void Main(string[] args)
        {
            //random object to generate random number
            Random random = new Random();
            bool playAgain = true; //user can play again
            int min = 1; 
            int max = 100; //will generate a number between min and max
            int guess; //user guessed number
            int number; //randomly generated number
            int guesses; //guesses count
            String response; //users response to play again

            while (playAgain)
            {
                guess = 0; 
                guesses = 0; //total guesses = 0;
                response = ""; 
                number = random.Next(min, max+1); //generate a random number between min and max and assign to number variable

                while (guess != number) //guessed number is equal to the generated random number 
                {
                    Console.WriteLine("Welcome to NUMBER HUNT :)");
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine()); //convert the guessed number to print store in guess variable
                    Console.WriteLine("Guess: " +guess); //print the guessed number

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!!!");
                    }
                    else if (guess < number) 
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win!!!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N) :");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing NUMBER HUNT!");

            Console.ReadKey();
        }
    }
}