using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.SearchPage
{
    public partial class SearchPage
    {
        public Element AdvancedSearchButton => Driver.FindElement(By.Id("ui-id-7"));
    }
}
