using Attributes;
using System.ComponentModel;

namespace Enums.LootFarm
{
    public enum LootFarmUrls
    {
        [Description("https://loot.farm/fullpriceDOTA.json")]
        [Game("Dota")]
        Dota_URL,
        [Description("https://loot.farm/fullpriceRUST.json")]
        [Game("Rust")]
        RUST_URL,
        [Description("https://loot.farm/fullpriceH1Z1.json")]
        [Game("H1Z1")]
        H1Z1_URL
    }
}
