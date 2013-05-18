﻿using System.Linq;
using NUnit.Framework;

namespace LinqExploration.Concatenation
{
    [TestFixture]
    internal class Concat
    {
        [Test]
        public void ConcatConcatenatesSequencesTogether()
        {
            var album1 = AlbumData.Artists1[0].Albums.First();
            var album2 = AlbumData.Artists1[1].Albums.First();
            var concatenatedAlbums = album1.Tracks.Concat(album2.Tracks);
            Assert.That(concatenatedAlbums.Count(), Is.EqualTo(album1.Tracks.Count() + album2.Tracks.Count()));
        }
    }
}