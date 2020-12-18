namespace SimeonGenov_TaskATP.Pages
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver Driver { get; private set; }

        public WebDriverWait Wait => new WebDriverWait(this.Driver, TimeSpan.FromSeconds(3));

    }
}
