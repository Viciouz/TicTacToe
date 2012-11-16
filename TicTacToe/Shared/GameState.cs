using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Shared
{
    [DataContract]
    public class GameState
    {
        [DataMember]
        public int CurrentPlayer { get; private set; }
        
        [DataMember]
        public int[] Plays { get; private set; }

        public GameState(int currentPlayer, int[] plays)
        {
            CurrentPlayer = currentPlayer;
            Plays = plays;
        }
    }
}