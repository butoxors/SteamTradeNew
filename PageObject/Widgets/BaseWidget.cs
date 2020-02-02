using OpenQA.Selenium;
using System;

namespace PageObject.Widgets
{
    public abstract class BaseWidget<T> where T : BaseWidget<T>
    {
        protected IWebElement webElement;

        protected BaseWidget(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public IWebElement GetWrappedElement()
        {
            return webElement;
        }

        public T GetSelfReference()
        {
            return (T)this;
        }

        public IWebElement FindElement(By by)
        {
            try
            {
                return this.webElement.FindElement(by);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
