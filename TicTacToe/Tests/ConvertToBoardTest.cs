using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client;
using Shared;
using NUnit.Framework;

namespace Tests
{
    class ConvertToBoardTest
    {
        [Test]
        public void ConvertsDictToBoard()
        {
            var arr = new Player[,] {{Player.None, Player.Cross, Player.Circle},{Player.Circle, Player.None, Player.Cross}};
            var dict = new Dictionary<Player, List<Coord>> {{Player.Circle, new List<Coord> {new Coord {X=2,Y=0},new Coord {X=0,Y=1}}},
                {Player.Cross, new List<Coord> {new Coord {X=1,Y=0}, new Coord{X=2,Y=1}}}};


            var converter = new BoardConverter();
            CollectionAssert.AreEqual(arr, converter.ConvertToBoard(dict, 2, 3));
        }

        [Test]
        public void ConvertsBoardToDict()
        {
            var arr = new Player[,] { { Player.None, Player.Cross, Player.Circle }, { Player.Circle, Player.None, Player.Cross } };
            var dict = new Dictionary<Player, List<Coord>> {{Player.Circle, new List<Coord> {new Coord {X=2,Y=0},new Coord {X=0,Y=1}}},
                {Player.Cross, new List<Coord> {new Coord {X=1,Y=0}, new Coord{X=2,Y=1}}}};

            var converter = new BoardConverter();
            CollectionAssert.AreEqual(dict, converter.ConvertToDictionary(arr));
        }
    }
}
