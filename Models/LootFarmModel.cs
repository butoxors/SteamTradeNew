namespace Models
{
    using Json;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class LootFatmModel : BaseModel<LootFatmModel>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("have")]
        public long Have { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("rate")]
        public long Rate { get; set; }
    }

}
