using System;

namespace TicTacToe
{
    class Program
    {
        private const int boardSize = 9;
        private const int rows = 3;
        private const int columns = 3;

        static void Main(string[] args)
        {
            char[] board = new char[boardSize];
            bool userSymbol = true;
            int cells;

            for (int i = 0; i < boardSize; i++)
            {
                board[i] = ' ';
            }

            while (true)
            {
                Console.Clear();
                DisplayBoard(board);

                var charSymbol = userSymbol ? "X" : "O";
                Console.WriteLine($"User {charSymbol}, choose a slot from 1 - {boardSize}:");

                var isValidChoice = int.TryParse(Console.ReadLine(), out cells);
                while (!isValidChoice || cells < 1 || cells > boardSize || board[cells - 1] != ' ')
                {
                    Console.WriteLine($"Error: Pick cells: 1-{boardSize} or cell is taken.");
                    isValidChoice = int.TryParse(Console.ReadLine(), out cells);
                }

                cells--;
                board[cells] = userSymbol ? 'X' : 'O';
                userSymbol = !userSymbol;


                if (CheckForWin(board, charSymbol[0]))
                {
                    Console.Clear();
                    DisplayBoard(board);
                    Console.WriteLine($"User {charSymbol} wins!");
                    break;
                }
                else if (IsBoardFull(board))
                {
                    Console.Clear();
                    DisplayBoard(board);
                    Console.WriteLine("The game is a tie game!");
                    break;
                }
            }

            Console.WriteLine("Press keyboard button to exit");
            Console.ReadKey();
        }

        static void DisplayBoard(char[] board)
        {
            Console.WriteLine("Tic-Tac-Toe Game:");
            Console.WriteLine("-------------");
            for (int i = 0; i < boardSize; i++)
            {
                Console.Write($" {board[i]} ");
                if (i % columns == columns - 1)
                    Console.WriteLine("\n-------------");
                else
                    Console.Write("|");
            }
        }

        static bool CheckForWin(char[] board, char symbol)
        {
            return (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                   (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                   (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
                   (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                   (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                   (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
                   (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                   (board[2] == symbol && board[4] == symbol && board[6] == symbol);
        }

        static bool IsBoardFull(char[] board)
        {
            foreach (var cell in board)
            {
                if (cell == ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
