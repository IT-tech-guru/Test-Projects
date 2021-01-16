using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_WinAppDriver.Views
{
    public partial class CalculatorStandardView
    {
        public void AssertResult(string expectedReslt)
        {
            string strResult = GetCalculatorResultText();
            // var actualResult = decimal.Parse(strResult);

            Assert.AreEqual(expectedReslt, strResult);
        }
    }
}
