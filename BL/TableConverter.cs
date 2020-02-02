using Extensions;
using Models;
using Models.SwapModel.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BL
{
    public class TableConverter
    {
        /// <summary>
        /// Merge two lists
        /// </summary>
        /// <param name="lootFarmModel"></param>
        /// <param name="swapModel"></param>
        /// <param name="flag">From Swap.GG to Loot.Farm</param>
        /// <returns></returns>
        public DataTable ConvertModels(List<LootFarmModel>lootFarmModel, List<Result> swapModel, bool flag = false)
        {
            DataTable dt = new DataTable();

            var joined = swapModel
                .Join(lootFarmModel, x => x.MarketName, y => y.Name, (x, y) => new
                {
                    x.MarketName,
                    LootPrice = y.Price / 100.0,
                    SwapPrice = x.Price.Value / 100.0,
                    LootHave = y.Have,
                    LootMax = y.Max,
                    SwapHave = x.Stock.Have,
                    SwapMax = x.Stock.Max,
                    Income = Math.Round(!flag ? (y.Price / 100.0) - (x.Price.Value / 100.0) : (x.Price.Value / 100.0) - (y.Price / 100.0), 2)
                })
                .Where(x => !flag ? (x.SwapHave < x.SwapMax) && x.LootHave > 0 : (x.LootHave < x.LootMax) && x.SwapHave > 0)
                .OrderBy(x => x.Income);
            dt.Init();
            foreach(var j in joined)
            {
                dt.Rows.Add(j.MarketName, j.LootPrice, j.SwapPrice, j.LootHave, j.LootMax, j.SwapHave, j.SwapMax, j.Income);
            }
            return dt;
        }
    }
}