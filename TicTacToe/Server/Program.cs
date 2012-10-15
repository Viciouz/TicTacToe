using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Shared;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int portNumber = 9998;
            Console.WriteLine("TicTacToe Server started on port {0}", portNumber);

            var tcpChannel = new TcpChannel(portNumber);
            ChannelServices.RegisterChannel(tcpChannel, false);

            var connector = typeof(GameServer);

            RemotingConfiguration.RegisterWellKnownServiceType(connector, "TicTacToe", WellKnownObjectMode.Singleton);

            Console.WriteLine("Press ENTER to quit");
            Console.ReadKey();
        }
    }

    class GameServer : MarshalByRefObject, IGameServer
    {
        private GameState gameState;
        private DateTime lastUpdated;

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
            var newerState = date > lastUpdated;

            var log = String.Format("Varible date: {0} - Returned {1}", date, newerState);
            Logger.Log(log);

            return newerState;
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
