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
        public bool ConnectToServer()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);

            Type requiredType = typeof (GameServerConnector);

            GameServerConnector remoteObject =
                (GameServerConnector) Activator.GetObject(requiredType, "tcp://localhost:9998/TicTacToe");

            return remoteObject.NewStateSince(DateTime.Now);
            
        }

    }
}
