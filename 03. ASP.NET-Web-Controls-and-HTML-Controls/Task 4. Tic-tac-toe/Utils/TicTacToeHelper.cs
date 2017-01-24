using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_4.Tic_tac_toe.Utils
{
    public class TicTacToeHelper
    {


        public int RandomIndex(int length)
        {
            var rand = new Random();

            return rand.Next(0, length);
        }

        public int GetAvailableMove(int[,] gameBoard, int playerId)
        {
            var row = -1;
            var col = -1;

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                // Check the row
                if (gameBoard[i, 0] == 0 && gameBoard[i, 1] == playerId && gameBoard[i, 2] == playerId)
                {
                    row = i;
                    col = 0;
                    break;
                }
                else if (gameBoard[i, 1] == 0 && gameBoard[i, 0] == playerId && gameBoard[i, 2] == playerId)
                {
                    row = i;
                    col = 1;
                    break;
                }
                else if (gameBoard[i, 2] == 0 && gameBoard[i, 0] == playerId && gameBoard[i, 1] == playerId)
                {
                    row = i;
                    col = 2;
                    break;
                }

                // Check the column
                if (gameBoard[0, i] == 0 && gameBoard[1, i] == playerId && gameBoard[2, i] == playerId)
                {
                    row = 0;
                    col = i;
                    break;
                }
                else if (gameBoard[1, i] == 0 && gameBoard[0, i] == playerId && gameBoard[2, i] == playerId)
                {
                    row = 1;
                    col = i;
                    break;
                }
                else if (gameBoard[2, i] == 0 && gameBoard[0, i] == playerId && gameBoard[1, i] == playerId)
                {
                    row = 2;
                    col = i;
                    break;
                }
            }



            // Check the diagonals
            if (gameBoard[0, 0] == 0 && gameBoard[1, 1] == playerId && gameBoard[2, 2] == playerId)
            {
                row = 0;
                col = 0;
            }
            else if (gameBoard[1, 1] == 0 && gameBoard[0, 0] == playerId && gameBoard[2, 2] == playerId)
            {
                row = 1;
                col = 1;
            }
            else if (gameBoard[2, 2] == 0 && gameBoard[0, 0] == playerId && gameBoard[1, 1] == playerId)
            {
                row = 2;
                col = 2;
            }
            else if (gameBoard[0, 2] == 0 && gameBoard[1, 1] == playerId && gameBoard[2, 0] == playerId)
            {
                row = 0;
                col = 2;
            }
            else if (gameBoard[1, 1] == 0 && gameBoard[0, 2] == playerId && gameBoard[2, 0] == playerId)
            {
                row = 1;
                col = 1;
            }
            else if (gameBoard[2, 0] == 0 && gameBoard[0, 2] == playerId && gameBoard[1, 1] == playerId)
            {
                row = 2;
                col = 0;
            }

            if (row != -1)
            {
                return row * 3 + col;
            }

            return -1;
        }

        public int CheckForWinner(int[,] gameBoard)
        {
            var winner = 0;

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                var player = gameBoard[i, 0];
                if (player != 0)
                {
                    // Check for matching row
                    if (player == gameBoard[i, 1] && player == gameBoard[i, 2])
                    {
                        return player;
                    }
                }

                // Check for matching column
                player = gameBoard[0, i];
                if (player != 0)
                {
                    if (player == gameBoard[1, i] && player == gameBoard[2, i])
                    {
                        return player;
                    }
                }
            }

            // Check for matching diagonal
            if (gameBoard[0, 0] != 0)
            {
                var player = gameBoard[0, 0];
                if (player == gameBoard[1, 1] && player == gameBoard[2, 2])
                {
                    return player;
                }
            }

            if (gameBoard[0, 2] != 0)
            {
                var player = gameBoard[0, 2];
                if (player == gameBoard[1, 1] && player == gameBoard[2, 0])
                {
                    return player;
                }
            }

            return winner;
        }
    }
}