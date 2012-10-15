using System;

namespace Shared
{
    public class GameState
    {
        public Player CurrentPlayer { get; private set; }
        public string Command { get; private set; }

        public GameState(Player currentPlayer, string command)
        {
            CurrentPlayer = currentPlayer;
            Command = command;
        }
    }
}