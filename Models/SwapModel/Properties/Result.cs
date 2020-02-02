using JsonHelper;
using Newtonsoft.Json;

namespace Models.SwapModel.Properties
{
    public class Result
    {
        [JsonProperty("appId")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AppId { get; set; }

        [JsonProperty("marketName")]
        public string MarketName { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("stock")]
        public Stock Stock { get; set; }
    }
}
