using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.SearchPage
{
    public partial class SearchPage
    {
        public IWebElement AdvancedSearchButton => Wait.Until(d => d.FindElement(By.Id("ui-id-7")));
    }
}
