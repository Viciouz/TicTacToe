using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;



namespace Client
{
    class Connection
    {
        private void ConnectToServer()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisteredChannels(tcpChannel, false);

            Type requiredType = typeof (GameServerConnector);


        }
    }
}
