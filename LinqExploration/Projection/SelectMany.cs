﻿using System.Collections.Generic;
using System.Linq;
using LinqExploration.AlbumData;
using NUnit.Framework;

// ReSharper disable LoopCanBeConvertedToQuery

namespace LinqExploration.Projection
{
    [TestFixture]
    internal class SelectMany
    {
        [Test]
        public void SelectManyToGetTheTracksOfAllAlbums()
        {
            var tracks = SampleData.Artists.SelectMany(artist => artist.Albums).SelectMany(album => album.Tracks);

            var totalNumberOfTracks = 0;
            foreach (var artist in SampleData.Artists)
            {
                foreach (var album in artist.Albums)
                {
                    totalNumberOfTracks += album.Tracks.Count();
                }
            }

            Assert.That(tracks, Is.AssignableTo<IEnumerable<Track>>());
            Assert.That(tracks.Count(), Is.EqualTo(totalNumberOfTracks));
        }
    }
}