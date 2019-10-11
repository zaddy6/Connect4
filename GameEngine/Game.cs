using System;

namespace GameEngine
{
    public class Game
    {
        private Cellstate[,] Board { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        private bool _player0Move = false;

        public Game(int width, int height)
        {
            if (width < 4 || height < 4)
            {
                throw new ArgumentException("Board has to be 4x4 at least");
            }

            Width = width;
            Height = height;
            
            Board = new Cellstate[width,height];
        }

        public Cellstate[,] BoardCopy()
        {
            var result = new Cellstate[Width, Height];
            
            Array.Copy(Board, result, Board.Length);

            return result;
        }

        public string Move(int x, int y)
        {
            if (Board[x, y] != Cellstate.Empty)
            {
                return "copy";
            }

            Board[x, y] = _player0Move ? Cellstate.X : Cellstate.O;
            _player0Move = !_player0Move;

            return "Ok";
        }


    }
}