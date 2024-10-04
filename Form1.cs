using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SODV2101Rapid_Assignment01
{
    public partial class Form1 : Form
    {
        internal Game TicTacToe { get; private set; }

        // Initialize components
        public Form1()
        {
            InitializeComponent();
            TicTacToe = new Game();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button cell = (Button)sender;

            // Return the player who made the turn
            int player = TicTacToe.Turn(int.Parse(cell.Tag as string));

            if (player == 1) // Player 1 made the move
            {
                cell.Text = "X";
                cell.BackColor = Color.Blue;
                lbl_Note.Text = "Player 2's turn.";
            }
            else // Player 2 made the move
            {
                cell.Text = "O";
                cell.BackColor = Color.Red;
                lbl_Note.Text = "Player 1's turn.";
            }

            // Check winning condition
            if (TicTacToe.CheckWin())
            {
                lbl_Note.Text = $"Congratulations! \nPlayer {player} wins!";
                DisableButtons(); // Disable all buttons at win
            }
            else if(TicTacToe.CheckDraw())
            {
                lbl_Note.Text = "It's a draw!"; // Game is a draw
                DisableButtons();
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            TicTacToe.ResetGame(); // Reset game logic
            ResetBoardUI(); // Reset UI to default state

        }

        private void ResetBoardUI()
        {
            foreach(Control control in Controls)
            {
                if(control is Button button && button.Name != "Btn_Reset")
                {
                    control.Text = string.Empty; // Clear text
                    control.BackColor = DefaultBackColor; // Reset button color
                    control.Enabled = true; // Enable buttons for new game
                }
            }
            lbl_Note.Text = "Player 1's turn.";
        }      
        private void DisableButtons() //Disable buttons after win
        {
            foreach(Control control in Controls)
            {
                if(control is Button && control.Name != "Btn_Reset") // All buttons except Reset button
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
