namespace Models
{
    using Newtonsoft.Json;

    public class LootFarmModel : BaseModel<LootFarmModel>
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
