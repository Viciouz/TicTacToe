using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Shared;

namespace Client
{
    class GameServerConnector
    {
        private IGameServer remoteObject;
        private GameState gameState;
        private DateTime lastUpdate;

        public GameState GameState
        {
            get
            {
                if(HasChanged())
                {
                    lastUpdate = DateTime.Now;
                    gameState = remoteObject.GameState;
                }
                return gameState;
            }

            set
            {
                remoteObject.GameState = value;
                gameState = value;
            }
        }

        public GameServerConnector()
        {
            var tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);

            var requiredType = typeof(IGameServer);
            remoteObject =
                (IGameServer)Activator.GetObject(requiredType, "tcp://localhost:9998/TicTacToe");
        }

        public bool HasChanged()
        {
            return remoteObject.NewStateSince(lastUpdate);
        }

        public Player StartNew()
        {
            return remoteObject.StartNewGame();
        }
    }
}
