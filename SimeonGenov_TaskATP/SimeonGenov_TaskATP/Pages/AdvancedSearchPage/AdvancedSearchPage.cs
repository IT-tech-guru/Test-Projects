using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchPage
{
    public partial class AdvancedSearchPage : BasePage
    {
        public AdvancedSearchPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public void ClickTownField()
        {
            TownField.Click();
        }

        public void FillTownField(string text)
        {
            TownField.SendKeys(text);
        }

        public void ClickFindZIPCodesButton()
        {
            FindZIPCodesButton.Click();
        }
    }
}
