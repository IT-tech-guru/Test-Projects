using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(Driver driver) 
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.GoToUrl("http://www.zip-codes.com/");
        }

        public void GoToSearch()
        {
            SearchButton.Click();
        }
    }
}
