using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
        protected WebDriverWait webDriverWait;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            IWebElement element = null;
            try
            {
                element = webDriver.FindElement(By.XPath(xPath));
            }
            catch (Exception) { }

            return element;
        }

        public ICollection<IWebElement> FindElementsByXPath(string xPath)
        {
            ICollection<IWebElement> elements = null;
            try
            {
                elements = webDriver.FindElements(By.XPath(xPath));
            }
            catch (Exception) { }

            return elements;
        }

        public void WaitBy(string by)
        {
            webDriverWait.Until<bool>(webDriver =>
            {
                try
                {
                    return webDriver.FindElement(By.XPath(by)).Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }
    }
}
