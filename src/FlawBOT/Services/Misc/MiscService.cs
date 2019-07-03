﻿using FlawBOT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlawBOT.Services
{
    public class EightBallService
    {
        public static string GetAnswer()
        {
            var random = new Random();
            return Answers.ElementAt(random.Next(Answers.Count()));
        }

        private static ImmutableArray<string> Answers = new[]
        {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        }.ToImmutableArray();
    }

    public class DogService
    {
        private static readonly string base_url = "https://dog.ceo/api/breeds/image/random";
        private static readonly HttpClient http = new HttpClient();

        public static async Task<DogData> GetDogPhotoAsync()
        {
            var results = await http.GetStringAsync(base_url);
            return JsonConvert.DeserializeObject<DogData>(results);
        }
    }
}