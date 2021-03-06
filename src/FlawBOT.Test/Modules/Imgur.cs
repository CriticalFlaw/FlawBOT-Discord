﻿using System.Threading.Tasks;
using FlawBOT.Services;
using NUnit.Framework;

namespace FlawBOT.Test
{
    [TestFixture]
    internal class Imgur
    {
        [Test]
        public async Task GetImgurGalleryData()
        {
            var results = await ImgurService.GetImgurGalleryAsync(TestSetup.Tokens.ImgurToken, "cats")
                .ConfigureAwait(false);
            Assert.IsNotNull(results);

            results = await ImgurService.GetImgurGalleryAsync(TestSetup.Tokens.ImgurToken, "dogs")
                .ConfigureAwait(false);
            Assert.IsNotNull(results);
        }
    }
}