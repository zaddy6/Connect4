using System;
using System.ComponentModel;
using GameEngine;

namespace ConsoleUI
{
    public class AppUI
    {
        private static readonly string _vertseperator = " | ";
        private static readonly string _horseperator = "-";
        private static readonly string _centerseperator = "+";


        public static void PrintBoard(Game game)
        {
            
            
            Console.Clear();

            var board = game.BoardCopy();

            for (var yIndex = 0; yIndex < game.Height; yIndex++)
            {
                var line = "";
                for (var xIndex = 0; xIndex < game.Width; xIndex++)
                {
                    line +=  GetSingleState(board[yIndex, xIndex]);

                    if (xIndex < game.Width - 1)
                    {
                        line += _vertseperator;
                    }

                }

                Console.WriteLine(line);
                   

                if (yIndex < (game.Height-1))
                {
                    line = "";
                    for (var xIndex = 0; xIndex < game.Width; xIndex++)
                    {
                        line += _horseperator;
                        line += " ";
                        if (xIndex < game.Width - 1)
                        {
                            line += _centerseperator;
                            line += " ";
                        }

                    }
                    Console.WriteLine(line);
                }
               
            }
        }
        
        
        public static string GetSingleState(CellState state)
        {
            switch (state)
            {
                case CellState.Empty:
                    return " ";
                case CellState.O:
                    return "O";
                case CellState.X:
                    return "X";
                default:
                    throw new InvalidEnumArgumentException("Unknown enum option");
            }
        }
    }
}