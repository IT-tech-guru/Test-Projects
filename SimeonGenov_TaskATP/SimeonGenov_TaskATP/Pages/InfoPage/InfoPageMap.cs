using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage
    {
        
        public IWebElement ZipCode => this.Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[1]/td[2]")));
        public IWebElement City => this.Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[2]/td[2]")));
        public IWebElement State => this.Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[3]/td[2]")));
        public IWebElement Longitude => this.Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[13]/td[2]")));
        public IWebElement Latitude => this.Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[14]/td[2]")));

    }
}
