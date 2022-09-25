using System;

namespace Unit01
{
    class Program
    {
        // Alma Benavides Project: Specification w02
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();
            List<string> board = GetNewBoard();
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
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

    }
}
