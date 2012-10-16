using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Client;
using Shared;

namespace Tests
{
    public class DetermineWinnerTests
    {
        [Test]
        public void RowWinners()
        {
            var cb = new CheckBoard();
            var board = new[,]
                {
                    {Player.Circle, Player.Circle, Player.Circle}, 
                    {Player.None, Player.None, Player.None},
                    {Player.None, Player.None, Player.None}
                };
            Assert.AreEqual(Player.Circle, cb.DetermineWinner(board));

            board = new[,]
                {
                    {Player.None, Player.None, Player.None},
                    {Player.Circle, Player.Circle, Player.Circle},
                    {Player.None, Player.None, Player.None}
                };
            Assert.AreEqual(Player.Circle, cb.DetermineWinner(board));

            board = new[,]
                {
                    {Player.None, Player.None, Player.None},
                    {Player.None, Player.None, Player.None},
                    {Player.Circle, Player.Circle, Player.Circle},
                };
            Assert.AreEqual(Player.Circle, cb.DetermineWinner(board));

            board = new[,]
                {
                    {Player.Cross, Player.None, Player.Cross},
                    {Player.None, Player.Circle, Player.None},
                    {Player.Circle, Player.Circle, Player.Circle},
                };
            Assert.AreEqual(Player.Circle, cb.DetermineWinner(board));
        }
    }
}
