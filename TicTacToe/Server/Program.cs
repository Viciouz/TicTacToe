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

            var connector = typeof (GameServer);

            RemotingConfiguration.RegisterWellKnownServiceType(connector, "TicTacToe", WellKnownObjectMode.Singleton);

            Console.WriteLine("Press ENTER to quit");
            Console.ReadKey();
        }
    }

    class GameServer : IGameServer
    {
        private GameState gameState; 
        public GameState GameState { get; set; }

        public bool NewStateSince(DateTime date)
        {
            return false;
        }
    }
}
