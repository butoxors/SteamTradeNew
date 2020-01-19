using Data;
using Enums.LootFarm;
using Models;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string json = new Downloader().DownloadString(LootFarmUrls.Dota_URL);
            var model = new LootFatmModel().FromJson(json);
        }
    }
}
