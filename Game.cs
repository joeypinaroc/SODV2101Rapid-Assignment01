using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODV2101Rapid_Assignment01
{
    internal class Game
    {
        // Declare properties for player and board
        private static Player _player1 { get; set; }
        private static Player _player2 { get; set; }
        private static Board _board { get; set; }

        // Initialize new game
        public Game()
        {
            _board = new Board();
        }

        // Method for the player to make a turn
        public int Turn(int cell)
        {
            return _board.Turn(cell);   
        }

        // Method to check if there is already a winner
        public bool CheckWin()
        {
            return _board.CheckWin();
        }

        // Method to check if the game is a draw
        public bool CheckDraw()
        {
            return _board.CheckDraw();
        }

        // Method to reset the game
        public void ResetGame()
        {
            _board.ResetBoard();
        }

    }


}
