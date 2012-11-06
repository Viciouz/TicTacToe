using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Client.ServiceReference1;
using Shared;

namespace Client
{
    class GameServerConnector
    {
        private ServiceReference1.GameServerClient s;
      //  private IGameServer remoteObject;
        private GameState gameState;
        private DateTime lastUpdate;

        public GameState GameState
        {
            get
            {
                if(HasChanged())
                {
                    
                    lastUpdate = DateTime.Now;
                    gameState = s.get_GameState();
                }
                return gameState;
            }

            set
            {
              //  remoteObject.GameState = value;
                s.set_GameState(value);
            }
        }

        public GameServerConnector()
        {
            s = new ServiceReference1.GameServerClient();

            /*  var tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);

            var requiredType = typeof(IGameServer);
            remoteObject =
                (IGameServer)Activator.GetObject(requiredType, "tcp://localhost:9998/TicTacToe");*/
        }

        public bool HasChanged()
        {
          return s.NewStateSince(lastUpdate);
            //  return remoteObject.NewStateSince(lastUpdate); */
        }

        public Player StartNew()
        {
           return s.StartNewGame();
            //  return remoteObject.StartNewGame();
        }
    }
}
