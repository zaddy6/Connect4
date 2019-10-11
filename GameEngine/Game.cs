using System;

namespace GameEngine
{
    public class Game
    {
        private CellState[,] Board { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        private bool _player0Move = false;

        public Game(int height, int width)
        {
            if (width < 4 || height < 4)
            {
                throw new ArgumentException("Board has to be 4x4 at least");
            }

            Height = height;
            Width = width;
            Board = new CellState[height,width];
        }

        public CellState[,] BoardCopy()
        {
            var result = new CellState[Height, Width];
            
            Array.Copy(Board, result, Board.Length);

            return result;
        }

        public string Move(int y, int x)
        {
            if (Board[y, x] != CellState.Empty)
            {
                return "copy";
            }

            Board[y, x] = _player0Move ? CellState.X : CellState.O;
            _player0Move = !_player0Move;

            return "Ok";
        }


    }
}