using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace SimeonGenov_TaskATP.Helpers
{
    public class WebDriver : Driver
    {
        public IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;

       public override IWebDriver WebDriverProp { get { return _webDriver; } }

        public override void Start(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.FireFox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
        }

        public override void Quit()
        {
            _webDriver.Quit();
        }

        public override void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);

            _webDriverWait.Until(driver1 => ((IJavaScriptExecutor)_webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public override void NavigateBack()
        {
            _webDriver.Navigate().Back();
        }


        public override Element FindElement(By locator)
        {
            IWebElement nativeWebElement =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            Element element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }

        public override List<Element> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<Element>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                Element element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }

        public override void TakeScreenshot(IWebDriver _webDriver, string saveLocation)
        {
            Screenshot ss = ((ITakesScreenshot)_webDriver).GetScreenshot();
            ss.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}
