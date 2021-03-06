﻿using FlawBOT.Services;
using NUnit.Framework;

namespace FlawBOT.Test
{
    [TestFixture]
    internal class Simpsons
    {
        [Test]
        public void GetFuturamaEpisode()
        {
            Assert.NotNull(SimpsonsService.GetSimpsonsDataAsync(SimpsonsService.SiteRoot.Morbotron).Result.Title);
        }

        [Test]
        public void GetRickMortyEpisode()
        {
            Assert.NotNull(SimpsonsService.GetSimpsonsDataAsync(SimpsonsService.SiteRoot.MasterOfAllScience).Result
                .Title);
        }

        [Test]
        public void GetSimpsonsEpisode()
        {
            Assert.NotNull(SimpsonsService.GetSimpsonsDataAsync(SimpsonsService.SiteRoot.Frinkiac).Result.Title);
        }
    }
}