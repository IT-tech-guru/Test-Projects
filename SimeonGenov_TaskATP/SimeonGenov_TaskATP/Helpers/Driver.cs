using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Helpers
{
    public abstract class Driver : IDriver
    {
        public abstract IWebDriver WebDriverProp { get; }
        public abstract void Start(Browser browser);
        public abstract void Quit();
        public abstract void GoToUrl(string url);
        public abstract void NavigateBack();
        public abstract Element FindElement(By locator);
        public abstract List<Element> FindElements(By locator);
        public abstract void TakeScreenshot(IWebDriver _webDriver, string saveLocation);

    }
}
