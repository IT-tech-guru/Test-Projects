using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.HomePage
{
    public partial class HomePage
    {
        public Element SearchButton => Driver.FindElement(By.CssSelector("[href*='/search.asp']"));
    }
}
