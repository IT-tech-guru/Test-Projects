using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Helpers
{
    public static class Utility
    {
        public static void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            // Cannot convert "Driver" to "ITakesScreenshot"
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}