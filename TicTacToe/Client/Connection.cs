﻿using System;
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

            Type requiredType = typeof(IGameServer);

            remoteObject =
                (IGameServer)Activator.GetObject(requiredType, "tcp://localhost:9998/TicTacToe");
        }

        public bool UpdatedSinceNow()
        {
            return remoteObject.NewStateSince(DateTime.Now);
        }

        public string GetPlayer()
        {
            return remoteObject.GameState.CurrentPlayer.ToString();
        }

        public void SetGameState(GameState gs)
        {
            remoteObject.GameState = gs;
        }

        public string GetMove()
        {
            return remoteObject.GameState.Command;
        }

        public Player StartNewGame()
        {
            return remoteObject.StartNewGame();
        }

        public Player[,] GetBoard()
        {
            return remoteObject.GameState.Board;
        }

    }
}
