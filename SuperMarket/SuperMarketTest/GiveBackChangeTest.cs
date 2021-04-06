using NFluent;
using NUnit.Framework;
using SuperMarket.Domain;
using System.Collections.Generic;

namespace SuperMarketTest
{
    public class GiveBackChangeTest
    {
        private GiveBackChange _changes;

        [SetUp]
        public void Setup()
        {

            _changes = new GiveBackChange();
        }

        [Test]
        public void ShouldReturn1pieceOf1EuroWhenGiveBackAmount1()
        {
            Check.That(_changes.GiveBack(1)).Equals(new List<Piece> { new Piece(1) });
        }
    }
}