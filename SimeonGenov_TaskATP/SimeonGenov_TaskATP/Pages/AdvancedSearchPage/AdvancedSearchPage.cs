using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchPage
{
    public partial class AdvancedSearchPage : BasePage
    {
        public AdvancedSearchPage(Driver driver) 
            : base(driver)
        {
        }

        public void ClickTownField()
        {
            TownField.Click();
        }

        public void FillTownField(string text)
        {
            TownField.TypeText(text);
        }

        public void ClickFindZIPCodesButton()
        {
            FindZIPCodesButton.Click();
        }
    }
}
