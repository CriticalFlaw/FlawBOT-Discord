﻿using System.Linq;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using FlawBOT.Common;
using FlawBOT.Properties;
using FlawBOT.Services;

namespace FlawBOT.Modules
{
    [Group("reddit")]
    [Description("Commands for findings posts on a subreddit.")]
    [Cooldown(3, 5, CooldownBucketType.Channel)]
    public class RedditModule : BaseCommandModule
    {
        #region COMMAND_HOT

        [Command("hot")]
        [Description("Get hottest posts from a given subreddit.")]
        public Task HotPost(CommandContext ctx, [Description("Subreddit.")] string query)
        {
            return RedditPost(ctx, query, RedditCategory.Hot);
        }

        #endregion COMMAND_HOT

        #region COMMAND_NEW

        [Command("new")]
        [Description("Get newest posts from a given subreddit.")]
        [Aliases("newest", "latest")]
        public Task NewPost(CommandContext ctx, [Description("Subreddit.")] string query)
        {
            return RedditPost(ctx, query, RedditCategory.New);
        }

        #endregion COMMAND_NEW

        #region COMMAND_TOP

        [Command("top")]
        [Description("Get top posts from a given subreddit.")]
        public Task TopPost(CommandContext ctx, [Description("Subreddit.")] string query)
        {
            return RedditPost(ctx, query, RedditCategory.Top);
        }

        #endregion COMMAND_TOP

        #region COMMAND_POST

        private static async Task RedditPost(CommandContext ctx, string query, RedditCategory category)
        {
            if (string.IsNullOrWhiteSpace(query)) return;
            await ctx.TriggerTypingAsync();
            var results = RedditService.GetResults(query, category);
            if (results is null || results.Count == 0)
            {
                await BotServices.SendResponseAsync(ctx, Resources.NOT_FOUND_COMMON, ResponseType.Missing)
                    .ConfigureAwait(false);
                return;
            }

            while (results.Count > 0)
            {
                var output = new DiscordEmbedBuilder()
                    .WithFooter("Type 'next' within 10 seconds for the next five posts.")
                    .WithColor(new DiscordColor("#FF4500"));

                foreach (var result in results.Take(5))
                {
                    output.AddField(result.Authors.FirstOrDefault()?.Name,
                        $"[{(result.Title.Text.Length < 500 ? result.Title.Text : result.Title.Text.Take(500) + "...")}]({result.Links.First().Uri})");
                    results.Remove(result);
                }

                var message = await ctx.RespondAsync("Search results for r/" + query + " on Reddit", output)
                    .ConfigureAwait(false);

                if (results.Count == 5) continue;
                var interactivity = await BotServices.GetUserInteractivity(ctx, "next", 10).ConfigureAwait(false);
                if (interactivity.Result is null) break;
                await BotServices.RemoveMessage(interactivity.Result).ConfigureAwait(false);
                await BotServices.RemoveMessage(message).ConfigureAwait(false);
            }
        }

        #endregion COMMAND_POST
    }
}