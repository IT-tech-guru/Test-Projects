using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage : BasePage
    {
        public InfoPage(IWebDriver driver) : base(driver)
        {
        }

        
        public void OpenGoogleMapsURL()
        {
            var zipCode = ZipCode.Text;
            var city = City.Text;
            var state = State.Text;
            var latitude = Latitude.Text;
            var longitude = Longitude.Text;
            string urlBase = "http://www.google.com/maps/place/";
            string url = urlBase + latitude + ", " + longitude;
            Driver.Navigate().GoToUrl(url);


            string name = String.Format(@"{0} - {1} - {2}",city, state, zipCode);
            string fileFullPath = String.Format(@"..\..\..\Screenshots\{0}.png", name);
            TakeScreenshot(Driver, fileFullPath);
        }

        private void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}
