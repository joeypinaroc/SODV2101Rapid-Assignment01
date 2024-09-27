using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODV2101Rapid_Assignment01
{
    internal class Game
    {
        private static Player _player1 { get; set; }
        private static Player _player2 { get; set; }
        private static Board _board { get; set; }

        public Game()
        {
            _board = new Board();
        }

        public int Turn(int cell)
        {
            return _board.Turn(cell);   
        }

        public bool CheckWin()
        {
            return _board.CheckWin();
        }


    }


}
