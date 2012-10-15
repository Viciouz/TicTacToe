using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Shared;

namespace Client
{
    class Connection
    {
        private IGameServer remoteObject;

        public Connection()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);
            
            Type requiredType = typeof (IGameServer);

            remoteObject =
                (IGameServer) Activator.GetObject(requiredType, "tcp://localhost:9998/TicTacToe");

             remoteObject.NewStateSince(DateTime.Now);
            
        }

        public string GetPlayer()
        {           
            return remoteObject.GameState.CurrentPlayer.ToString();
        }

        public void SetGameState(GameState gs)
        {
            remoteObject.GameState = gs;
        }

    }
}
