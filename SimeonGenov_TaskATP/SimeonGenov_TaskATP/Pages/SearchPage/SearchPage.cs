using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.SearchPage
{
    public partial class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToAdvancedSearch()
        {
            this.AdvancedSearchButton.Click();
        }
    }
}
