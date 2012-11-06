using System;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.ServiceModel.Description;
using Shared;
using System.Collections.Generic;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RunServer();
        }

        public static void RunServer()
        {
            ServiceHost host = new ServiceHost(typeof(GameServer));

            host.Open();

            foreach (var endpoint in host.Description.Endpoints)
                Console.WriteLine(endpoint.Address);
            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();

            host.Abort();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class GameServer : IGameServer
    {
        private GameState gameState;
        private DateTime lastUpdated;
        private int currentNumberOfPlayers = 0;

        public GameState GameState
        {
            get { return gameState; }
            set
            {
                gameState = value;
                lastUpdated = DateTime.Now;
            }
        }

        public bool NewStateSince(DateTime date)
        {
            var newerState = date < lastUpdated;

            var log = String.Format("Varible date: {0} - Returned {1}", date, newerState);
            Logger.Log(log);

            return newerState;
        }

        public Player StartNewGame()
        {
            Player nextPlayer;
            switch (currentNumberOfPlayers)
            {
                case 0:
                    nextPlayer = Player.Circle;
                    Logger.Log("First player joined");
                    ResetBoard();
                    Logger.Log("Board reset");
                    break;
                case 1:
                    nextPlayer = Player.Cross;
                    Logger.Log("Second player joined");
                    break;
                default:
                    nextPlayer = Player.None;
                    Logger.Log("Some douche who cannot play joined");
                    break;
            }

            currentNumberOfPlayers += 1;
            return nextPlayer;
        }

        private void ResetBoard()
        {
            var state = new Dictionary<Player, List<Coord>> { 
            { Player.Circle, new List<Coord>() }, 
            { Player.Cross, new List<Coord>() } 
            };
            GameState = new GameState(Player.Circle, state);
        }
    }

    class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine("{0} - {1}", DateTime.Now, text);
        }
    }
}
