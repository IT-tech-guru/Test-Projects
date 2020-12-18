using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage
{
    public partial class AdvancedSearchResultsPage
    {
        public IWebElement Result1 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[1]")));
        public IWebElement Result2 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[2]")));
        public IWebElement Result3 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[3]")));
        public IWebElement Result4 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[4]")));
        public IWebElement Result5 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[5]")));
        public IWebElement Result6 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[6]")));
        public IWebElement Result7 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[7]")));
        public IWebElement Result8 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[8]")));
        public IWebElement Result9 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[9]")));
        public IWebElement Result10 => Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[10]")));
    }
}
