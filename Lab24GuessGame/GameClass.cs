using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24GuessGame
{
    class GameClass
    {
        private static Random random;
        private int secretNumber;
        private int guess;
        private int numberOfTries;

        public GameClass()
        {
            random = new Random();
            secretNumber = 0;
            guess = 0;
            numberOfTries = 0;
        }

        public void PlayGame()
        {
            secretNumber = GetRandomNumber();

            do
            {
                numberOfTries++;
                guess = GetUserResponse();

                if (guess == -1)
                {
                    Console.WriteLine("bye");
                    return;
                }
                bool gameOver = PromptandGetResponse(secretNumber, guess);
                if (gameOver)
                {
                    break;
                }
            } while (true);

        }

        private bool PromptandGetResponse(int secretNumber, int guess)
        {
            bool gameOver = false;
            if (secretNumber == guess)
            {
                if (numberOfTries == 10)
                {
                    Console.WriteLine("you know the secret");
                }
                else if (numberOfTries > 10)
                {
                    Console.WriteLine("you should be able to");
                }
                else
                {
                    Console.WriteLine("lucky");
                }
                gameOver = true;
            }
            else if (secretNumber < guess)
            {
                Console.WriteLine($"{secretNumber}-guess lower");
            }
            else
            {
                Console.WriteLine($"{secretNumber}-guess higher");

            }
            return gameOver;
        }

        private int GetUserResponse()
        {
            Console.Write("enter guess [1-1000]: ");
            return int.Parse(Console.ReadLine());
        }

        private int GetRandomNumber() => random.Next(1,1001);
        
    }
}
