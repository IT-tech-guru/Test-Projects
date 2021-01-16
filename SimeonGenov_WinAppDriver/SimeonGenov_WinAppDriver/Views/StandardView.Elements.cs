using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium.Windows;

namespace SimeonGenov_WinAppDriver.Views
{
   public partial class CalculatorStandardView
    {
        public WindowsElement ZeroButton => _driver.FindElementByName("Zero");
        public WindowsElement OneButton => _driver.FindElementByName("One");
        public WindowsElement TwoButton => _driver.FindElementByName("Two");
        public WindowsElement ThreeButton => _driver.FindElementByName("Three");
        public WindowsElement FourButton => _driver.FindElementByName("Four");
        public WindowsElement FiveButton => _driver.FindElementByName("Five");
        public WindowsElement SixButton => _driver.FindElementByName("Six");
        public WindowsElement SevenButton => _driver.FindElementByName("Seven");
        public WindowsElement EightButton => _driver.FindElementByName("Eight");
        public WindowsElement NineButton => _driver.FindElementByName("Nine");
        public WindowsElement PlusButton => _driver.FindElementByName("Plus");
        public WindowsElement MinusButton => _driver.FindElementByName("Minus");
        public WindowsElement EqualsButton => _driver.FindElementByName("Equals");
        public WindowsElement DivideButton => _driver.FindElementByName("Divide by");
        public WindowsElement MultiplyByButton => _driver.FindElementByName("Multiply by");
        public WindowsElement ResultsInput => _driver.FindElementByName("CalculatorResults");
        public WindowsElement Navigation => _driver.FindElementByName("Open Navigation");
        public WindowsElement TemperatureConverter => _driver.FindElementByName("Temperature Converter");
        public WindowsElement VolumeConverter => _driver.FindElementByName("Volume Converter");
        public WindowsElement InputUnit => _driver.FindElementByName("Input unit");
        public WindowsElement OutputUnit => _driver.FindElementByName("Output unit");
        public WindowsElement CubicCentimeters => _driver.FindElementByName("Cubic centimeters");
        public WindowsElement CubicFeet => _driver.FindElementByName("Cubic feet");
        public WindowsElement Celsius => _driver.FindElementByName("Celsius");
        public WindowsElement Fahrenheit => _driver.FindElementByName("Fahrenheit");
    }
}
