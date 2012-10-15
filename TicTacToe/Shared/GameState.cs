using System;

namespace Shared
{
    [Serializable]
    public class GameState
    {
        public Player CurrentPlayer { get; private set; }
        public Player[,] Board { get; private set; }

        public GameState(Player currentPlayer, Player[,] board)
        {
            CurrentPlayer = currentPlayer;
            Board = board;
        }
    }
}