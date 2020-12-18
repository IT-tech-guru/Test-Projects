using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        { 
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://www.zip-codes.com/");
        }

        public void GoToSearch()
        {
            this.SearchButton.Click();
        }
    }
}
