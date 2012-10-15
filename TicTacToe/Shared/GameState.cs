using System;

namespace Shared
{
    [Serializable]
    public class GameState
    {
        public Player CurrentPlayer { get; private set; }
        public string Command { get; private set; }
        public Player[] Board { get; private set; }

        public GameState(Player currentPlayer, string command, Player[] board)
        {
            CurrentPlayer = currentPlayer;
            Command = command;
            Board = board;
        }
    }
}