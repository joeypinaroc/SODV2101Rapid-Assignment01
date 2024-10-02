using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODV2101Rapid_Assignment01
{

    internal class Board
    {
        private static int[] _boardstate { get; set; }
        private static int[][] _win { get; set; }
        private static int _turn { get; set; }

        internal Board()
        {
            _boardstate = new int[9]; // Initial board
            _win = new int[][] // Winning positions
                {
                new int[] {0, 1, 2},
                new int[] {3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {0, 3, 6},
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                new int[] {0, 4, 8},
                new int[] {2, 4, 6}
                };
            _turn = 0; // Player turn
        }

        public int Turn(int cell)
        {
            _turn = _turn % 2;
            _turn++;
            _boardstate[cell] = _turn;
            return _turn;
        }

        // Condition to check if there is already a winner
        public bool CheckWin()
        {
            {
                foreach (var rwin in _win)
                {

                    if (_boardstate[rwin[0]] == _turn && _boardstate[rwin[1]] == _turn && _boardstate[rwin[2]] == _turn)
                    {
                        return true;
                    }  
                }
                return false;
            }

        }
        public void ResetBoard()
        {
            _boardstate = new int[9];
            _turn = 0;
        }
    }
}
