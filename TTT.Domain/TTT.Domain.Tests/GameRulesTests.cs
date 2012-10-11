using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TTT.Domain.Tests
{
    public class GameRulesTests
    {
        [Test]
        public void NobodyWinsAnEmptyBoard()
        {
            var gr = new GameRules();
            var gameboard = new[,]
                {
                    {Player.None, Player.None, Player.None},
                    {Player.None, Player.None, Player.None},
                    {Player.None, Player.None, Player.None}
                };

            Assert.AreEqual(Player.None, gr.Winner(gameboard));
        }
    }
}