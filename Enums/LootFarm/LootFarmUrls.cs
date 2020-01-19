using System.ComponentModel;

namespace Enums.LootFarm
{
    public enum LootFarmUrls
    {
        [Description("https://loot.farm/fullpriceDOTA.json")]
        Dota_URL,
        [Description("https://loot.farm/fullpriceRUST.json")]
        RUST_URL,
        [Description("https://loot.farm/fullpriceH1Z1.json")]
        H1Z1_URL
    }
}
