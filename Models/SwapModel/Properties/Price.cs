using Enums;
using Newtonsoft.Json;

namespace Models.SwapModel.Properties
{
    public class Price
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("sides")]
        public Sides Sides { get; set; }

        [JsonProperty("factor")]
        public double Factor { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }
}
