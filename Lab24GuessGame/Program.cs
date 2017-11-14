using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Play guessing game? [Y|N]: ");
                char response = Console.ReadLine().ToUpper()[0];

                if (response.Equals('Y'))
                {
                    GameClass game = new GameClass();
                    game.PlayGame();
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine("bye");
        }
    }
}
