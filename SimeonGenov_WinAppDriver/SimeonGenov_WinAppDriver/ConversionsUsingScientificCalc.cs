using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using SimeonGenov_WinAppDriver.Views;

namespace SimeonGenov_WinAppDriver
{
    class ConversionsUsingScientificCalc
    {
        private WindowsDriver<WindowsElement> _driver;
        private CalculatorStandardView _calcStandardView;

        [SetUp]
        public void TestInit()
        {
            var options = new AppiumOptions();

            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            _calcStandardView = new CalculatorStandardView(_driver);
        }

        [TearDown]
        public void TestCleanup()
        {
            _driver?.Quit();
        }

        [Test]
        [TestCase(2, "Converts into 0.000071 Cubic feet")]
        [TestCase(3, "Converts into 0.000106 Cubic feet")]
        public void TestConvertCubicCentimetersToCubicFeetOneDigit(int num1, string result)
        {
            _calcStandardView.ConvertCubicCentimetersToCubicFeetOneDigit(num1);
            _calcStandardView.AssertResult(result);

        }

        [Test]
        [TestCase(2, 5, "Converts into 0.000883 Cubic feet")]
        [TestCase(3, 6, "Converts into 0.001271 Cubic feet")]
        public void TestConvertCubicCentimetersToCubicFeetTwoDigit(int num1, int num2, string result)
        {
            _calcStandardView.ConvertCubicCentimetersToCubicFeetTwoDigit(num1, num2);
            _calcStandardView.AssertResult(result);

        }

        [Test]
        [TestCase(2, 5, 8, "Converts into 0.009111 Cubic feet")]
        [TestCase(3, 6, 9, "Converts into 0.013031 Cubic feet")]
        public void TestConvertCubicCentimetersToCubicFeetThreeDigit(int num1, int num2, int num3, string result)
        {
            _calcStandardView.ConvertCubicCentimetersToCubicFeetThreeDigit(num1, num2, num3);
            _calcStandardView.AssertResult(result);

        }


        [Test]
        [TestCase(2, "Converts into 35.6 Fahrenheit")]
        [TestCase(3, "Converts into 37.4 Fahrenheit")]
        public void TestConvertCelsiusToFahrenHeitOneDigit(int num1, string result)
        {
            _calcStandardView.ConvertCelsiusToFahrenHeitOneDigit(num1);
            _calcStandardView.AssertResult(result);

        }

        [Test]
        [TestCase(2, 5, "Converts into 77 Fahrenheit")]
        [TestCase(3, 6, "Converts into 96.8 Fahrenheit")]
        public void TestConvertCelsiusToFahrenHeitTwoDigit(int num1, int num2, string result)
        {
            _calcStandardView.ConvertCelsiusToFahrenHeitTwoDigit(num1, num2);
            _calcStandardView.AssertResult(result);

        }

        [Test]
        [TestCase(2, 5, 8, "Converts into 496.4 Fahrenheit")]
        [TestCase(3, 6, 9, "Converts into 696.2 Fahrenheit")]
        public void TestConvertCelsiusToFahrenHeitThreeDigit(int num1, int num2, int num3, string result)
        {
            _calcStandardView.ConvertCelsiusToFahrenHeitThreeDigit(num1, num2, num3);
            _calcStandardView.AssertResult(result);

        }
    }
}
