using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage : BasePage
    {
        private IWebDriver _webDriver;
        public InfoPage(Driver driver)
            : base(driver)
        {
            _webDriver = Driver.WebDriverProp;
        }

        public void AddCookieForGoogleMaps()
        {
            DateTime time = DateTime.Now.AddYears(18);
            _webDriver.Manage().Cookies.DeleteCookieNamed("CONSENT");
            _webDriver.Manage().Cookies.AddCookie(new Cookie("CONSENT", "YES+BG.bg+V9+BX", ".google.com", "/", time));
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

            string name = string.Format(@"{0} - {1} - {2}", city, state, zipCode);
            string fileFullPath = string.Format(@"..\..\..\Screenshots\{0}.png", name);

            Driver.TakeScreenshot(_webDriver, fileFullPath);
        }
    }
}

