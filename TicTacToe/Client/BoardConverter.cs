using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared;

namespace Client
{
    public class BoardConverter
    {
     /*   public Player[,] ConvertToBoard(int[] plays, int boardheight, int boardwidth)
        {
            Player[,] NewBoard = new Player[boardheight, boardwidth];

            foreach (var kvp in plays)
            {
                foreach (var coord in kvp.Value)
                {
                    NewBoard[coord.Y, coord.X] = kvp.Key;
                }
            }

            return NewBoard;
        }
        */
     /*   public Dictionary<Player, List<Coord>> ConvertToDictionary(Player[,] board)
        {
            Dictionary<Player, List<Coord>> NewDictionary = new Dictionary<Player, List<Coord>>();  

            for (int y = 0; y < board.GetLength(0); y++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    if (board[y,x] != Player.None)
                    {
                        Player p = board[y, x];
                        var c = new Coord {X=x,Y=y};
                        if (NewDictionary.ContainsKey(p))
                            NewDictionary[p].Add(c);
                        else
                            NewDictionary.Add(p, new List<Coord> { c });
                    }
                }
            }
            return NewDictionary;

        }
        */
        public Player[,] ConvertToPlayerArray (int[] arr, int rowCount)
        {
            Player[,] playerBoard = new Player[rowCount,rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (arr[i + j] == 1)                
                      playerBoard[i,j] = Player.Circle;
                    else if (arr[i + j] == 2)
                        playerBoard[i,j] = Player.Cross;
                    else 
                        playerBoard[i,j] = Player.None;
                }
            }

            return playerBoard;
        }

        public int[] ConvertToArray (Player[,] pArr, int rowCount)
        {
            int[] arr = new int[rowCount*rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if(pArr[i,j] == Player.Circle)
                        arr[i + j] = 1;
                    else if(pArr[i,j] == Player.Cross)
                        arr[i + j] = 2;
                    else
                        arr[i + j] = 0;
                }
            }

            return arr;
        }
    }
}
