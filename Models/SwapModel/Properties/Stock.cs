using Newtonsoft.Json;

namespace Models.SwapModel.Properties
{
    public class Stock
    {
        [JsonProperty("have")]
        public long Have { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }
    }
}
