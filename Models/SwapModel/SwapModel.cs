using System.Collections.Generic;
using Models.SwapModel.Properties;
using Newtonsoft.Json;

namespace Models.SwapModel
{
    public class SwapModel : BaseModel<SwapModel>
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public List<Result> Result { get; set; }
    }
}
