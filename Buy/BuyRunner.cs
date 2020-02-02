namespace Buy
{
    public class LootRunner : ARunner
    {
        public LootRunner() : base() { }

        public void OpenLootPage()
        {
            webDriver.Navigate().GoToUrl(lootPage.URL);
        }

        public void LogIn()
        {
            lootPage.ClickLogIn();
        }
    }
}
