using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.Pages;

namespace Buy
{
    public abstract class ARunner
    {
        protected LootPage lootPage;

        protected static IWebDriver webDriver = new ChromeDriver();

        public ARunner()
        {
            webDriver.Manage().Window.Maximize();
            lootPage = new LootPage(webDriver);
        }
    }
}
