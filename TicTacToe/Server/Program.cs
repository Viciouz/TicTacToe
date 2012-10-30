using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.ServiceModel.Description;
using Shared;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select connection \n1: WCF \n2: Remoting");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    SetWCF();
                    break;
                case "2":
                    SetRemoting();
                    break;
                default:
                    Console.WriteLine("Select 1 or 2");
                    break;
            }

        }

        public static void SetWCF()
        {
            Uri baseAddress = new Uri("http://localhost:8080/WCFtest");
            ServiceHost host = new ServiceHost(typeof(GameServer), baseAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy12;
            //smb.HttpGetBinding = new BasicHttpBinding();
            host.Description.Behaviors.Add(smb);

            host.Open();

            Console.WriteLine("WCF Service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();

            host.Abort();

        }

        public static void SetRemoting()
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

    class GameServer : MarshalByRefObject, IGameServer
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
            GameState = new GameState(Player.Circle, new[,] { { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None } });
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
