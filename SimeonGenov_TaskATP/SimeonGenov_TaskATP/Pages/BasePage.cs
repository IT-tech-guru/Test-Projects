using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SimeonGenov_TaskATP.Pages
{  
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; private set; }

        public WebDriverWait Wait => new WebDriverWait(this.Driver, TimeSpan.FromSeconds(3));
    }
}
