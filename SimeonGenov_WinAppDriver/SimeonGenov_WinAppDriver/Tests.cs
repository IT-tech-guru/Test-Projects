using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace SimeonGenov_WinAppDriver
{
    class Tests
    {
        private WindowsDriver<WindowsElement> _driver;

        [SetUp]
        public void TestInit()
        {
            var options = new AppiumOptions();

            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void TestCleanup()
        {
            _driver?.Quit();
        }

        [Test]
        [TestCase("Two", "Converts into 0.000071 Cubic feet")]
        [TestCase("Three", "Converts into 0.000106 Cubic feet")]
        [TestCase("Four", "Converts into 0.000141 Cubic feet")]
        public void ConvertToCubicFeetFromCubicCentimeters(string input1, string expectedResult) { 
            _driver.FindElementByName("Open Navigation").Click();
            Thread.Sleep(3000);
            _driver.FindElementByName("Volume Converter").Click();
            _driver.FindElementByName("Input unit").Click();
            _driver.FindElementByName("Cubic centimeters").Click();
            _driver.FindElementByName("Output unit").Click();
            _driver.FindElementByName("Cubic feet").Click();
            _driver.FindElementByName(input1).Click();
            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }


        [Test]
        [TestCase("Two", "Converts into 35.6 Fahrenheit")]
        [TestCase("Three", "Converts into 37.4 Fahrenheit")]
        [TestCase("Four", "Converts into 39.2 Fahrenheit")]
        public void ConvertToFahrenHeitFromCelsius(string input1, string expectedResult)
        {
            _driver.FindElementByName("Open Navigation").Click();
            Thread.Sleep(3000);
            _driver.FindElementByName("Temperature Converter").Click();
            _driver.FindElementByName("Input unit").Click();
            _driver.FindElementByName("Celsius").Click();
            _driver.FindElementByName("Output unit").Click();
            _driver.FindElementByName("Fahrenheit").Click();
            _driver.FindElementByName(input1).Click();
            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }

        private string GetCalculatorResultText()
        {
            return _driver.FindElementByAccessibilityId("Value2").Text.Replace("Display is", string.Empty).Trim();
        }
    }
}
