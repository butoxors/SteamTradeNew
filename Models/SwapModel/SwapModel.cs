using Models.SwapModel.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.SwapModel
{
    public class SwapModel
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public List<Result> Result { get; set; }
    }
}
