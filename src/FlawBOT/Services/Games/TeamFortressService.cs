﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FlawBOT.Properties;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Models.GameEconomy;
using SteamWebAPI2.Utilities;
using TeamworkTF.Sharp;

namespace FlawBOT.Services
{
    public class TeamFortressService : HttpHandler
    {
        private static SteamWebInterfaceFactory _steamInterface;
        private static List<SchemaItem> ItemSchemaList { get; } = new();

        #region NEWS

        public static async Task<List<News>> GetNewsArticlesAsync(string token, int page = 0, string provider = "")
        {
            List<News> results;
            if (page > 0)
                results = await new TeamworkClient(token).GetNewsByPageAsync(page)
                    .ConfigureAwait(false);
            else if (provider != string.Empty)
                results = await new TeamworkClient(token).GetNewsByProviderAsync(provider)
                    .ConfigureAwait(false);
            else
                results = await new TeamworkClient(token).GetNewsOverviewAsync()
                    .ConfigureAwait(false);
            return results.Where(x => x.Type != "tf2-notification").ToList();
        }

        #endregion NEWS

        #region CREATORS

        public static async Task<List<Creator>> GetContentCreatorAsync(string token, ulong query)
        {
            return await new TeamworkClient(token)
                .GetYouTubeCreatorAsync(query.ToString())
                .ConfigureAwait(false);
        }

        #endregion CREATORS

        #region SCHEMA

        public static SchemaItem GetSchemaItem(string query)
        {
            return ItemSchemaList.Find(n => n.ItemName.Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }

        public static async Task<bool> UpdateTf2SchemaAsync(string token)
        {
            try
            {
                _steamInterface = new SteamWebInterfaceFactory(token);
                var steam = _steamInterface.CreateSteamWebInterface<EconItems>(AppId.TeamFortress2, new HttpClient());
                var games = await steam.GetSchemaItemsForTF2Async().ConfigureAwait(false);
                ItemSchemaList.Clear();
                foreach (var game in games.Data.Result.Items)
                    if (!string.IsNullOrWhiteSpace(game.Name))
                        ItemSchemaList.Add(game);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Resources.ERR_TF2_LIST, ex.Message);
                return false;
            }
        }

        #endregion SCHEMA

        #region SERVERS

        public static async Task<GameMode> GetGameModeInfoAsync(string token, string query)
        {
            return await new TeamworkClient(token).GetGameModeAsync(query)
                .ConfigureAwait(false);
        }

        public static async Task<List<Server>> GetServersByGameModeAsync(string token, string query)
        {
            return await new TeamworkClient(token).GetServerListByGameModeAsync(query)
                .ConfigureAwait(false);
        }

        public static async Task<List<ServerList>> GetCustomServerListsAsync(string token)
        {
            return await new TeamworkClient(token).GetServerListsAsync()
                .ConfigureAwait(false);
        }

        public static string GetServerInfo(string token, string address)
        {
            return new TeamworkClient(token).GetServerBanner(address);
        }

        #endregion SERVERS

        #region MAPS

        public static async Task<Map> GetMapStatsAsync(string token, string query)
        {
            var map = new TeamworkClient(token).GetMapsBySearchAsync(query).Result
                .FirstOrDefault()?.Name;
            return await new TeamworkClient(token).GetMapStatsAsync(map)
                .ConfigureAwait(false);
        }

        public static async Task<MapThumbnail> GetMapThumbnailAsync(string token, string query)
        {
            return await new TeamworkClient(token).GetMapThumbnailAsync(query)
                .ConfigureAwait(false);
        }

        #endregion MAPS
    }
}