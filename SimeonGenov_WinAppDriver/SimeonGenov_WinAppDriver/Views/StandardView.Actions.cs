using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium.Windows;

namespace SimeonGenov_WinAppDriver.Views
{
    public partial class CalculatorStandardView
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        public CalculatorStandardView(WindowsDriver<WindowsElement> driver) => _driver = driver;

        public void PerformCalculation(int num1, char operation, int num2)
        {
            ClickByDigit(num1);
            PerformOperations(operation);
            ClickByDigit(num2);
            EqualsButton.Click();
        }

        public void ConvertCelsiusToFahrenHeitOneDigit(int num1)
        {
            PrepareConversionCelsiusToFahrenHeit();
            ClickByDigit(num1);
        }

        public void ConvertCelsiusToFahrenHeitTwoDigit(int num1, int num2)
        {
            PrepareConversionCelsiusToFahrenHeit();
            ClickByDigit(num1);
            ClickByDigit(num2);
        }
        public void ConvertCelsiusToFahrenHeitThreeDigit(int num1, int num2, int num3)
        {
            PrepareConversionCelsiusToFahrenHeit();
            ClickByDigit(num1);
            ClickByDigit(num2);
            ClickByDigit(num3);
        }

        public void PrepareConversionCelsiusToFahrenHeit()
        {
            Navigation.Click();
            TemperatureConverter.Click();
            InputUnit.Click();
            Celsius.Click();
            OutputUnit.Click();
            Fahrenheit.Click();
        }

        public void ConvertCubicCentimetersToCubicFeetOneDigit(int num1)
        {
            PrepareConversionCubicCentimetersToCubicFeet();
            ClickByDigit(num1);
        }

        public void ConvertCubicCentimetersToCubicFeetTwoDigit(int num1, int num2)
        {
            PrepareConversionCubicCentimetersToCubicFeet();
            ClickByDigit(num1);
            ClickByDigit(num2);
        }

        public void ConvertCubicCentimetersToCubicFeetThreeDigit(int num1, int num2, int num3)
        {
            PrepareConversionCubicCentimetersToCubicFeet();
            ClickByDigit(num1);
            ClickByDigit(num2);
            ClickByDigit(num3);
        }

        public void PrepareConversionCubicCentimetersToCubicFeet()
        {
            Navigation.Click();
            VolumeConverter.Click();
            InputUnit.Click();
            CubicCentimeters.Click();
            OutputUnit.Click();
            CubicFeet.Click();
        }

        private void ClickByDigit(int digit)
        {
            switch (digit)
            {
                case 1:
                    OneButton.Click();
                    break;
                case 2:
                    TwoButton.Click();
                    break;
                case 3:
                    ThreeButton.Click();
                    break;
                case 4:
                    FourButton.Click();
                    break;
                case 5:
                    FiveButton.Click();
                    break;
                case 6:
                    SixButton.Click();
                    break;
                case 7:
                    SevenButton.Click();
                    break;
                case 8:
                    EightButton.Click();
                    break;
                case 9:
                    NineButton.Click();
                    break;
                default:
                    throw new NotSupportedException($"Not Supported digit = {digit}");
            }
        }

        private void PerformOperations(char operation)
        {
            switch (operation)
            {
                case '+':
                    PlusButton.Click();
                    break;
                case '-':
                    MinusButton.Click();
                    break;
                case '=':
                    EqualsButton.Click();
                    break;
                case '*':
                    MultiplyByButton.Click();
                    break;
                case '/':
                    DivideButton.Click();
                    break;
                default:
                    throw new NotSupportedException($"Not Supported operation = {operation}");
            }
        }

        //private string GetCalculatorResultText() => 
        //    ResultsInput.Text.Replace("Display is", string.Empty).Trim();

        private string GetCalculatorResultText()
        {
            return _driver.FindElementByAccessibilityId("Value2").Text.Replace("Display is", string.Empty).Trim();
        }
    }
}
