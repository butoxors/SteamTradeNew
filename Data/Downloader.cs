using Models;
using Models.SwapModel;
using System.Net;
using System.Net.Http;

namespace Data
{
    public static class DataDownloader
    {
        public static dynamic GetItemsFromLootFarm(string uri)
        {
            WebClient client = new WebClient();
            var json = client.DownloadString(uri);
            var items = BaseModel<LootFarmModel>.FromJsonToList(json);

            return items;
        }

        public static dynamic GetItemsFromSwapGG(string uri)
        {
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                HttpResponseMessage response = client.GetAsync(uri).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                var items = BaseModel<SwapModel>.FromJson(result).Result;

                return items;
            }
        }
    }
}
