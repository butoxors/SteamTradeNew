using Enums;
using Models;
using Models.SwapModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Data
{
    public static class DataDownloader
    {
        public static dynamic GetItemsFromLootFarm(Enum uri)
        {
            WebClient client = new WebClient();
            var json = client.DownloadString(uri.GetDescription());
            var items = BaseModel<LootFarmModel>.FromJsonToList(json);
            return items;
        }

        public static dynamic GetItemsFromSwapGG(Enum uri)
        {
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                HttpResponseMessage response = client.GetAsync(uri.GetDescription()).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                var items = BaseModel<SwapModel>.FromJson(result).Result;

                return items;
            }
        }
    }
}
