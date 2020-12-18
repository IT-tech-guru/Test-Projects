using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage
{
    public partial class AdvancedSearchResultsPage
    {
        public IWebElement Result1 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[1]")));
        public IWebElement Result2 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[2]")));
        public IWebElement Result3 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[3]")));
        public IWebElement Result4 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[4]")));
        public IWebElement Result5 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[5]")));
        public IWebElement Result6 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[6]")));
        public IWebElement Result7 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[7]")));
        public IWebElement Result8 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[8]")));
        public IWebElement Result9 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[9]")));
        public IWebElement Result10 => this.Wait.Until(d => d.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[10]")));

    }
}
