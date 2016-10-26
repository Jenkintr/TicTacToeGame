using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulator
{
    public partial class TicTacToe : Form
    {
        //Variables:
        bool turn = true; // true = x turn; false = o turn;
        int turn_count = 0;

        public TicTacToe()
        {
            InitializeComponent();
            turnIdentiferLabel.Text = "Player X's Turn.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /************************************************************************
         * square_click event handler allow the user to take turns making a mark*
         * on the board to determine a winner.                                  *
         ************************************************************************/
        private void square_click(object sender, EventArgs e)
        {
            showTurn();
            Label xo = (Label)sender;
            if (turn)
            {
                xo.Text = "X";
            }
            else
            {
                xo.Text = "O";
            }

            turn = !turn; //Changes the turn 
            xo.Enabled = false;
            turn_count++;
            checkForWinner();
            
        }//end square_click

        /**********************************************************************
         * The checkForWinner method will check each turn to see if anyone has*
         * won the game.                                                      *
         **********************************************************************/
        private void checkForWinner()
        {
            bool isWinner = false;

            //Check Horizontal
            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                isWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                isWinner = true;
            }

            //Check Vertical
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                isWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                isWinner = true;
            }

            //Check Vertical
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                isWinner = true;
            }
           

            //If winner is found show the winner.
            if (isWinner)
            {
                disableSquares(); //disable buttons if theres a winner

                String winner;
                if (turn)
                {
                    winner = "O";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "Winner!");
            }
            else //Show there was a tie.
            {
                if(turn_count == 9)
                {
                  MessageBox.Show("There was a draw.", "TIE!");
                  tie_win_count.Text = (Int32.Parse(tie_win_count.Text) + 1).ToString();
                }
            }
        }//end checkForWinner

        /**********************************************************************
         * The showTurn method will reset all the values so that a new game   *
         * can begin.                                                         *
         **********************************************************************/
        private void showTurn()
        {
            if (turn)
                turnIdentiferLabel.Text = "Player O's Turn.";
            else
                turnIdentiferLabel.Text = "Player X's Turn.";
        }//end showTurn

        /**********************************************************************
         * The disableSquares method will disable all of the squares so that  *
         * a player cannot change another users choice.                       *
         **********************************************************************/
        private void disableSquares()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;

        }//end disableSquares

        /***********************************************************************
         * The startNewGame method will reset all the values so that a new game*
         * can begin.                                                          *
         ***********************************************************************/
        private void startNewGame(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            turnIdentiferLabel.Text = "Player X's Turn.";

            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }//end startNewGame

        /***********************************************************************
         * The clearButton_Click handler will reset all the score values.      *
         ***********************************************************************/
        private void clearButton_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            tie_win_count.Text = "0";
        }//end clearButton_Click

        
    }
}
