using System;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        // Alma Benavides Project: Specification w02
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();
            List<string> board = GetNewBoard();
            string currentPlayer = "x";

            while (!gameOver(board))
            {
                DisplayBoard(board);

                int choice = GetMoveChoice(currentPlayer);
                MakeMove(board, choice, currentPlayer);

                currentPlayer = GetNextPlayer(currentPlayer);
            }

            DisplayBoard(board);
            Console.WriteLine("Thanks for playing!");
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Tic-Tac-Toe game!");
        }

        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-----");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-----");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static bool gameOver(List<string> board)
        {
            bool gameOver = false;

            if (winner(board, "x") || winner(board, "o") || IsTie(board))
            {
                gameOver = true;
            }

            return gameOver;
        }

        static bool winner(List<string> board, string player)
        {

            bool winner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                winner = true;
            }

            return winner; 
        }
        static bool IsTie(List<string> board)
        {
            bool foundDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return !foundDigit;
        }

        static string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }

        static int GetMoveChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s must choose a number (1-9): ");
            string move_string = Console.ReadLine();

            int choice = int.Parse(move_string);
            return choice;
        }

        static void MakeMove(List<string> board, int choice, string currentPlayer)
        {
            int index = choice - 1;
            board[index] = currentPlayer;

        }
    }
}
