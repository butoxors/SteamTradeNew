using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace PageObject.Pages
{
    public class LootPage : BasePage
    {
        public readonly string URL = "https://loot.farm/";
        #region Locators
        private string UserLogInBy => "//div[@id='userNoLogin']";
        private string Dota2BotInventoryTabBy => "//div[@class='active']//img[@title='DOTA 2']";
        private string Dota2UserInventoryTabBy => "//div[@class='']//img[@title='DOTA 2']";
        private string TradeButtonBy => "//div[@id='tradeButton']";
        private string MyBalanceBy => "//div[@id='myBalance']";
        private string InpSearchBotBy => "//input[@id='searchBot']";
        private string InpSearchUserBy => "//input[@id='searchUser']";
        private string BotItemsBy => "//div[@id='bots_inv']/div[@class='itemwrap']";
        private string UserItemsBy => "//div[@id='user_inv']/div[@class='itemwrap']";
        private string UserAmountBy => "//div[@id='bots_amount']";
        private string UserLeftAmountBy => "//span[@id='bots_left_amount']";
        #endregion Locators
        #region Elements
        public IWebElement UserLogIn => FindElementByXPath(UserLogInBy);
        public IWebElement Dota2BotInventoryTab => FindElementByXPath(Dota2BotInventoryTabBy);
        public IWebElement Dota2UserInventoryTab => FindElementByXPath(Dota2UserInventoryTabBy);
        public IWebElement TradeButton => FindElementByXPath(TradeButtonBy);
        public IWebElement MyBalance => FindElementByXPath(MyBalanceBy);
        public IWebElement InpSearchBot => FindElementByXPath(InpSearchBotBy);
        public IWebElement InpSearchUser => FindElementByXPath(InpSearchUserBy);
        public ICollection<IWebElement> BotItems => FindElementsByXPath(BotItemsBy);
        public ICollection<IWebElement> UserItems => FindElementsByXPath(UserItemsBy);
        public IWebElement UserAmount => FindElementByXPath(UserAmountBy);
        public IWebElement UserLeftAmount => FindElementByXPath(UserLeftAmountBy);
        #endregion Elements
        public LootPage(IWebDriver webDriver) : base(webDriver) { }

        public string GetMyBalance => MyBalance.Text;

        public void ClickByDota2BotInventoryTab() => Dota2BotInventoryTab.Click();

        public void ClickByDota2UserInventoryTab() => Dota2UserInventoryTab.Click();

        public void ClickByTradeButton() => TradeButton.Click();

        public void ClickLogIn()
        {
            UserLogIn.Click();
        }

        public void SearchItemFromBotInventory(string itemName)
        {
            InpSearchBot.Clear();
            InpSearchBot.SendKeys(itemName);
        }

        public void SearchItemFromUserInventory(string itemName)
        {
            InpSearchUser.Clear();
            InpSearchUser.SendKeys(itemName);
        }

        public void SelectFirstItemFromBotInventory() => BotItems.First().Click();

        public void SelectFirstItemFromUserInventory() => UserItems.First().Click();
    }
}
