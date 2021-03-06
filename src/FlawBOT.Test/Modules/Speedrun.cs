﻿using FlawBOT.Services;
using NUnit.Framework;

namespace FlawBOT.Test
{
    [TestFixture]
    internal class Speedrun
    {
        [Test]
        public void GetSpeedrunGame()
        {
            Assert.Greater(SpeedrunService.GetSpeedrunGameAsync("Wind Waker").Result.Data.Count, 0);
            Assert.AreEqual(SpeedrunService.GetSpeedrunGameAsync("Wind Wanker").Result.Data.Count, 0);
        }
    }
}