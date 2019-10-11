using System;
using ConsoleUI;
using GameEngine;

namespace Connect4
{
    public static class PlayGame
    {
        public static string SmallBoard()
        {
            Start(5, 6);
            return "";
        }
        
        


        private static string Start(int h, int w)
        {
            var turn = 0;
            var playerOne = true;
            var game = new Game(h, w);

            var yCord = new int[w];

            for (int i = 0; i < w; i++)
            {
                yCord[i] = h-1;
            } 
            Console.Clear();
            var done = false;
            do
            { 
                Console.Clear(); 
                AppUI.PrintBoard(game);

                var userX = -1;

            do
            {
                Console.WriteLine("Please enter a column number, player" + (playerOne ? "One" : "Two"));
                Console.WriteLine(">");


                var userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out userX))
                {
                    Console.WriteLine($"{userInput} is not a number");
                    userX = -1;
                } else if (userX >= w) userX = -1;

            } while (userX < 0 || yCord[userX] < 0);
            
            if (game.Move(yCord[userX], userX) == "Ok")
            {
                turn++;
                yCord[userX]--;
                playerOne = !playerOne;
            }
            done = turn == h*w;
            } while (!done);

            AppUI.PrintBoard(game);
            Console.WriteLine("Game Over");
            Console.ReadKey();
            Console.Clear();

            return "";
        }
    }
}