using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Shared
{
    [DataContract]
    public class GameState
    {
        [DataMember]
        public Player CurrentPlayer { get; private set; }
        
        [DataMember]
        public Dictionary<Player, List<Coord>> Plays { get; private set; }

        public GameState(Player currentPlayer, Dictionary<Player, List<Coord>> plays)
        {
            CurrentPlayer = currentPlayer;
            Plays = plays;
        }
    }

    [DataContract]
    public struct Coord
    {
        [DataMember]
        public int X;
        [DataMember]
        public int Y;
    }

}