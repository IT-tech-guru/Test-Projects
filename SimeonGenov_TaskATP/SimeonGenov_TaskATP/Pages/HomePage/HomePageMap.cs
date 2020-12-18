using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimeonGenov_TaskATP.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement SearchButton => this.Wait.Until(d => d.FindElement(By.CssSelector("[href*='/search.asp']")));
    }
}
