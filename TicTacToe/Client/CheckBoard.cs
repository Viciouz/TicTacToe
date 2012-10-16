using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared;

namespace Client
{
    class CheckBoard
    {
        public Player CheckArray(Player[,] arr)
        {
            int Circle_Status = 0;
            int Cross_Status = 0;

            var binArr = new[,]
                                {
                                    {1, 2, 4},
                                    {8, 16, 32},
                                    {64, 128, 256}
                                };

            var winCombinations = new[] { 7, 56, 73, 84, 146, 273, 292, 448 };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == Player.Cross)
                    {
                        Cross_Status += binArr[i, j];
                    }

                    if (arr[i, j] == Player.Circle)
                    {
                        Circle_Status += binArr[i, j];
                    }
                }
            }

            foreach (var winSum in winCombinations)
            {
                if (Cross_Status == winSum)
                {
                    return Player.Cross;
                }

                if (Circle_Status == winSum)
                {
                    return Player.Circle;
                }
            }
            return Player.None;
        }

        public bool FullBoard(Player[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i,j] == Player.None)
                        return false;

            return true;
        }
    }
}
