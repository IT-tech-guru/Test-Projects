using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage : BasePage
    {
        public InfoPage(Driver driver) 
            : base(driver)
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
            Driver.GoToUrl(url);

            // Click on cookies consent "I agree" - cannot find element properly (not sure why).
            // Same Xpath selector is valid when using console in browser
            //var iAgreeCookies = Driver.FindElement(By.XPath("(//span[@class = 'RveJvd snByac'])[1]"));
            //iAgreeCookies.Click();

            //Remove cookie consent as an alert?
            //Driver.GetWebDriverField().SwitchTo().Alert().Accept();

            string name = string.Format(@"{0} - {1} - {2}",city, state, zipCode);
            string fileFullPath = string.Format(@"..\..\..\Screenshots\{0}.png", name);

            Utility.TakeScreenshot(Driver.GetWebDriverField(), fileFullPath);
            
            // This does not work. WebDriverOnj property is Null.
            //Utility.TakeScreenshot(Driver.WebDriverObj, fileFullPath);
        }

    }
}
