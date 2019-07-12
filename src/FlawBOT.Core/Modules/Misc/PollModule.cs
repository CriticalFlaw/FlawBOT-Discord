﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using FlawBOT.Framework.Models;
using FlawBOT.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlawBOT.Modules.Misc
{
    [Cooldown(3, 5, CooldownBucketType.Channel)]
    public class PollModule : BaseCommandModule
    {
        #region COMMAND_POLL

        [Command("poll")]
        [Description("Run a Yay or Nay poll in the current channel")]
        public async Task Poll(CommandContext ctx,
            [Description("Poll timer, in minutes")] string time,
            [Description("Question to be polled")] [RemainingText] string question)
        {
            if (!int.TryParse(time, out var minutes))
                await BotServices.SendEmbedAsync(ctx, "Invalid number of minutes, try **.poll 3 What is the fifth digit of Pi?**", EmbedType.Warning);
            else if (string.IsNullOrWhiteSpace(question))
                await BotServices.SendEmbedAsync(ctx, "You need to provide a poll question", EmbedType.Warning);
            else
            {
                var interactivity = ctx.Client.GetInteractivity();
                var pollOptions = new List<DiscordEmoji>();
                pollOptions.Add(DiscordEmoji.FromName(ctx.Client, ":thumbsup:"));
                pollOptions.Add(DiscordEmoji.FromName(ctx.Client, ":thumbsdown:"));
                var duration = new TimeSpan(0, 0, minutes, 0, 0);
                var output = new DiscordEmbedBuilder().WithDescription(ctx.User.Mention + ": " + question);
                var message = await ctx.RespondAsync(embed: output.Build());
                foreach (var react in pollOptions)
                    await message.CreateReactionAsync(react);
                var pollResult = await interactivity.CollectReactionsAsync(message, duration);
                var results = pollResult.Where(x => pollOptions.Contains(x.Emoji)).Select(x => $"{x.Emoji} wins the poll with **{x.Total}** votes");
                await ctx.RespondAsync(string.Join("\n", results));
            }
        }

        #endregion COMMAND_POLL
    }
}