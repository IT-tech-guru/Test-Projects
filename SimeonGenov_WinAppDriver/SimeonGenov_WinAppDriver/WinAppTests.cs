using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace SimeonGenov_WinAppDriver
{
    public class WinAppTests
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
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }

        [Test]
        [TestCase("Nine", "48.2")]
        [TestCase("Eight", "46.4")]
        [TestCase("Seven", "44.6")]
        [TestCase("Six", "42.8")]
        public void CelsiusOneDigitToFahrenHeit(string input1, string expectedResult)
        {
            _driver.FindElementByName(input1).Click();

            CelsiusToFahrenHeit();

            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }

        [Test]
        [TestCase("Two", "Three", "73.4")]
        [TestCase("Three", "Four", "93.2")]
        [TestCase("Four", "Six", "114.8")]
        [TestCase("Five", "Eight", "136.4")]
        public void CelsiusTwoDigitToFahrenHeit(string input1, string input2, string expectedResult)
        {
            _driver.FindElementByName(input1).Click();
            _driver.FindElementByName(input2).Click();

            CelsiusToFahrenHeit();

            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }

        //(°C × 9/5) + 32 = °F


        private void CelsiusToFahrenHeit()
        {
            _driver.FindElementByName("Multiply by").Click();
            Thread.Sleep(3000);
            _driver.FindElementByName("Nine").Click();
            Thread.Sleep(1000);
            _driver.FindElementByName("Divide by").Click();
            _driver.FindElementByName("Five").Click();
            _driver.FindElementByName("Plus").Click();
            _driver.FindElementByName("Three").Click();
            _driver.FindElementByName("Two").Click();
            _driver.FindElementByName("Equals").Click();
        }




        [Test]
        [TestCase("One", "0.0010764")]
        [TestCase("Five", "0.005382")]
        [TestCase("Eight", "0.0086112")]
        public void Cm2ToFt2OneDigit(string input1, string expectedResult)
        {
            _driver.FindElementByName(input1).Click();

            Cm2ToFt2();

            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }

        [Test]
        [TestCase("One", "One", "0.0118404")]
        [TestCase("Two", "Five", "0.02691")]
        [TestCase("Five", "Nine", "0.0635076")]
        public void Cm2ToFt2TwoDigit(string input1, string input2, string expectedResult)
        {
            _driver.FindElementByName(input1).Click();
            _driver.FindElementByName(input2).Click();

            Cm2ToFt2();

            Assert.AreEqual(expectedResult, GetCalculatorResultText());
        }

        //ft² =cm² * 0.0010764

        public void Cm2ToFt2()
        {
            _driver.FindElementByName("Multiply by").Click();
            Thread.Sleep(3000);
            _driver.FindElementByName("Zero").Click();
            _driver.FindElementByName("Decimal Separator").Click();
            _driver.FindElementByName("Zero").Click();
            _driver.FindElementByName("Zero").Click();
            _driver.FindElementByName("One").Click();
            _driver.FindElementByName("Zero").Click();
            _driver.FindElementByName("Seven").Click();
            _driver.FindElementByName("Six").Click();
            _driver.FindElementByName("Four").Click();
            _driver.FindElementByName("Equals").Click();


        }




        private string GetCalculatorResultText()
        {
            return _driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
        }
    }
}