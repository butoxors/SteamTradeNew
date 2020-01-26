using Attributes;
using System.ComponentModel;

namespace Enums.SwapGG
{
    public enum SwapGGUrls
    {
        [Description("https://api.swap.gg/prices/570")]
        [Game("Dota")]
        Dota_URL,
        [Description("https://api.swap.gg/prices/252490")]
        [Game("Rust")]
        RUST_URL,
        [Description("https://api.swap.gg/prices/433850")]
        [Game("H1Z1")]
        H1Z1_URL
    }
}
