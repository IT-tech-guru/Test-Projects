using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchPage
{
    public partial class AdvancedSearchPage
    {
        public IWebElement TownField => Wait.Until(d => d.FindElement(By.CssSelector("input[name ='fld-city'][size ='15']")));
        public IWebElement FindZIPCodesButton => Wait.Until(d => d.FindElement(By.CssSelector("#ui-id-8 > form > input.srchButton")));
    }
}
