/*using System;

namespace MyconsoleApp
{
    class Guessinggame
    {
        static void Main(string[] args)
        {
            string word = "lord"; //the word to guess
            string guess = "";// your guess
            int limit = 3; // most number of guesses
            int guesscount = 0; // number of guesses
            bool outofguesses = false; //if your out of guesses


            while (guess != word && !outofguesses) //loops while u havent guessed correctly and arent out of guesses
            {

                

                if( guesscount < limit)//if guess is less than the limit
                {
                    Console.Write("Enter a guess: "); //promt
                    guess = Console.ReadLine();//your guess
                    guesscount++;// increments guesscount

                }
                else
                {
                    outofguesses = true; // you are out of guesses
                    

                }
            }

            if (outofguesses)
            {
                Console.Write("you loose");
            }

            else
            {
                Console.Write("you win");
            }
            Console.ReadLine();
            
             
        }
    }
}*/