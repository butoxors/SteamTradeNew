using System.Collections.Generic;
using System.Data;

namespace Extensions
{
    public static class DateTableExtension
    {
        private static List<string> members = new List<string>()
        {
            "MarketName",
            "LootPrice",
            "SwapPrice",
            "LootHave",
            "LootMax",
            "SwapHave",
            "SwapMax",
            "Income"
        };

        public static DataTable Init(this DataTable dt)
        {
            members.ForEach(x => dt.Columns.Add(x));
            return dt;
        }
    }
}
