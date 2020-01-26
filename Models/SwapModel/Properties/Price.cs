using Newtonsoft.Json;

namespace Models.SwapModel.Properties
{
    public class Price
    {
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
