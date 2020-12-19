using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage : BasePage
    {
        public IWebDriver _webDriver;
        public InfoPage(Driver driver) 
            : base(driver)
        {
            _webDriver = Driver.GetWebDriverField();
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
            Driver.GoToUrl(url);

            string name = string.Format(@"{0} - {1} - {2}",city, state, zipCode);
            string fileFullPath = string.Format(@"..\..\..\Screenshots\{0}.png", name);

            Utility.TakeScreenshot(Driver.GetWebDriverField(), fileFullPath);
        }

    }
}
