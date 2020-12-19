using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages
{  
    public abstract class BasePage
    {
        protected readonly Driver Driver;
        public BasePage(Driver driver)
        {
            Driver = driver;
        }
    }
}
