using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Helpers
{
    interface IScreenShot
    {
        public void TakeScreenshot(IWebDriver _webDriver, string saveLocation);
    }
}
