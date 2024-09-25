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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button Move = (Button)sender;

            lbl_Input.Text = Move.Tag as string; // Identify the button clicked by the player
            Move.Text = "X"; // Change 'X' or 'O'

        }
    }
}
