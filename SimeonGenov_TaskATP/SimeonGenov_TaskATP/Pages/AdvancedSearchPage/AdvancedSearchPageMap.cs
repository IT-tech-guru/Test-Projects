using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchPage
{
    public partial class AdvancedSearchPage
    {
        public Element TownField => Driver.FindElement(By.CssSelector("input[name ='fld-city'][size ='15']"));
        public Element FindZIPCodesButton => Driver.FindElement(By.CssSelector("#ui-id-8 > form > input.srchButton"));
    }
}
