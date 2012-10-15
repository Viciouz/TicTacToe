using System;

namespace Shared
{
    public class GameState
    {
        public DateTime CreationTime { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public Command Command { get; private set; }

        public GameState(DateTime creationTime, Player currentPlayer, Command command)
        {
            CreationTime = creationTime;
            CurrentPlayer = currentPlayer;
            Command = command;
        }
    }
}