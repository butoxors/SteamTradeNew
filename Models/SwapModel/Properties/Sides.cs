using Newtonsoft.Json;

namespace Models.SwapModel.Properties
{
    public class Sides
    {
        [JsonProperty("user")]
        public long User { get; set; }

        [JsonProperty("bot")]
        public long Bot { get; set; }
    }
}
