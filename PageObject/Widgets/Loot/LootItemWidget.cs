using OpenQA.Selenium;

namespace PageObject.Widgets.Loot
{
    public class LootItemWidget : BaseWidget<LootItemWidget>
    {
        private string ItemName => ".//div[contains(@class,'it_name')]";
        private string ItemPrice => ".//div[contains(@class,'it_price')]";
        private string CountOfItems => ".//span[@onclick='expandItems(event)']";

        public LootItemWidget(IWebElement webElement) : base(webElement)
        {
        }

        public string GetItemName()
        {
            return this.GetWrappedElement().FindElement(By.XPath(ItemName)).Text;
        }

        public string GetItemPrice()
        {
            return this.GetWrappedElement().FindElement(By.XPath(ItemPrice)).Text;
        }

        public string GetItemCount()
        {
            return this.GetWrappedElement().FindElement(By.XPath(CountOfItems)).Text;
        }
    }
}
