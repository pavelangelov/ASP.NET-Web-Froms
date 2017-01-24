using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task_4.Tic_tac_toe.Utils;

namespace Task_4.Tic_tac_toe
{
    public partial class Tic_Tac_Toe : System.Web.UI.Page
    {
        private int playerId = 1;
        private int computerId = 2;
        private TicTacToeHelper helper;

        public Tic_Tac_Toe()
        {
            this.helper = new TicTacToeHelper();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;

            clickedButton.Enabled = false;
            clickedButton.Text = "X";

            var buttons = this.GetButtonsArray();

            var gameBoard = this.FillBoard(buttons);

            var winner = this.helper.CheckForWinner(gameBoard);
            if (winner > 0)
            {
                // The player is winner
                this.DisableButtons(buttons);
                this.winner.InnerText = "You win!";
                this.Restart.Visible = true;
                return;
            }
            else
            {
                // Check for computer`s winning move
                var btnId = this.helper.GetAvailableMove(gameBoard, this.computerId);
                if (btnId > -1)
                {
                    // Computer wins
                    buttons[btnId].Text = "O";
                    this.DisableButtons(buttons);

                    this.winner.InnerText = "You lose!";
                    this.Restart.Visible = true;
                    return;
                }

                // Check for saving move
                btnId = this.helper.GetAvailableMove(gameBoard, this.playerId);
                if (btnId > -1)
                {
                    buttons[btnId].Text = "O";
                    buttons[btnId].Enabled = false;
                    return;
                }

                var freeCells = buttons.Where(x => x.Enabled).ToArray();


                if (freeCells.Length == 0)
                {
                    this.winner.InnerText = "Game over! No more available moves!";
                    this.Restart.Visible = true;
                }
                else
                {
                    var index = this.helper.RandomIndex(freeCells.Length);
                    var nextFreeCell = freeCells[index];
                    nextFreeCell.Text = "O";
                    nextFreeCell.Enabled = false;
                }
            }
        }

        private Button[] GetButtonsArray()
        {
            var buttons = new Button[]
            {
                this.Button1,
                this.Button2,
                this.Button3,
                this.Button4,
                this.Button5,
                this.Button6,
                this.Button7,
                this.Button8,
                this.Button9
            };

            return buttons;
        }

        private void DisableButtons(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private int[,] FillBoard(Button[] buttons)
        {
            var cells = new int[3, 3];
            foreach (var button in buttons)
            {
                var cell = int.Parse(button.Attributes["data-id"]);
                var row = cell / 3;
                var col = cell % 3;

                if (button.Text == "X")
                {
                    cells[row, col] = 1;
                }
                else if (button.Text == "O")
                {
                    cells[row, col] = 2;
                }
            }

            return cells;
        }
    }
}