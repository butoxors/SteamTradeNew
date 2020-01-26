using BL;
using Data;
using Enums.LootFarm;
using Enums.SwapGG;
using Extensions;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class MainView : Form
    {
        private string lootUrl = LootFarmUrls.Dota_URL.GetDescription();
        private string swapUrl = SwapGGUrls.Dota_URL.GetDescription();

        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loot = DataDownloader.GetItemsFromLootFarm(lootUrl);
            var swap = DataDownloader.GetItemsFromSwapGG(swapUrl);
            var flag = sourcesCB1.SelectedIndex == 0 ? false : true;
            var dataSource = new TableConverter().ConvertModels(loot, swap, flag);

            mainData.Init();

            mainData.DataSource = dataSource;

            btnGetData.Enabled = false;
        }

        private void changeDirection_Click(object sender, EventArgs e)
        {
            var comboboxes = DirectionGB.Controls;
            foreach (var c in comboboxes)
            {
                if (c is ComboBox)
                {
                    var cm = (c as ComboBox);
                    cm.SelectedIndex = Math.Abs(cm.SelectedIndex - 1);
                }
            }
        }

        private void gameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lootUrl = gameSelector.Text.GetGameUrl<LootFarmUrls>();
            swapUrl = gameSelector.Text.GetGameUrl<SwapGGUrls>();
            btnGetData.Enabled = true;
        }
        
    }
}
