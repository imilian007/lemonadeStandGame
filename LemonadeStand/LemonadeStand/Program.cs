using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            void RunGame()
            {
                game.RunGame();
            }

            RunGame();
        }
    }
}
