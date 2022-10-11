using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4_AD_DP
{
    public partial class FindTheIslandGame : Form
    {
        int row = 0;
        int column = 0;
        byte guessRow = 0;
        byte guessCol = 0;
        int guessCount = 0;

        NavigationSystem navigationSystem;


        public FindTheIslandGame()
        {
            InitializeComponent();


            rowGuessBox.Enabled = false;
            colGuessBox.Enabled = false;
            guessButton.Enabled = false;


        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (guessButton.Text == "Guess")
            {
                // now that user is guessing, convert the text they entered from string to int
                mapBox.Text = "";
                guessRow = (byte)Convert.ToInt32(rowGuessBox.Text);
                guessCol = (byte)Convert.ToInt32(colGuessBox.Text);

                if (guessRow < row && guessCol < column)
                {
                    mapBox.Text = "";
                    mapBox.Text = navigationSystem.EvalGuess(guessRow, guessCol);
                    // disable play button to prevent resizing map
                    playButton.Enabled = false;

                    guessCount++;
                    guessCountBox.Text = guessCount.ToString();
                }
                else
                {
                    MessageBox.Show("Out of Range ");
                }
            }   else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {// try catch for error exception
            try
            {
                // text is constant, but just to additional error prevention
                if (playButton.Text == "PLAY")
                {
                    // set row to value entered by user
                    row = Convert.ToInt32(rowAmountBox.Text);
                    // set the number of columns on the map input by user
                    column = Convert.ToInt32(colAmountBox.Text);
                    // now that the game has started the guess boxes will be accessible
                    rowGuessBox.Enabled = true;
                    colGuessBox.Enabled = true;
                    guessButton.Enabled = true;

                    mapBox.Text = "";
                    // create new instance of the navsystem
                    navigationSystem = new NavigationSystem(row, column);
                    // print the map generated so the user can begin to play the game
                    mapBox.Text = navigationSystem.PrintMap();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Out of bounds" + MessageBoxButtons.RetryCancel + MessageBoxIcon.Error);
            }
        }
        // when the value for row is updated, if left blank it will default to 15 in order to try to stay
        // within the bounds of the map output box
        private void rowAmountBox_ValueChanged(object sender, EventArgs e)
        {
            string val = rowAmountBox.Text;
            if (rowAmountBox.Text != "")
            {
                if(int.Parse(val) > 15)
                {
                    rowAmountBox.Text = "15";
                }
            }
        }
        // when the value for column is updated, if left blank it will default to 15 in order to try to stay
        // within the bounds of the map output box
        private void colAmountBox_ValueChanged(object sender, EventArgs e)
        {
            string val = colAmountBox.Text;
            if (colAmountBox.Text != "")
            {
                if (int.Parse(val) > 15)
                {
                    colAmountBox.Text = "15";
                }
            }
        }
        // error preventing by only allowing backspace and numbers to be entered
        private void rowAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        // error preventing by only allowing backspace and numbers to be entered
        private void colAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
