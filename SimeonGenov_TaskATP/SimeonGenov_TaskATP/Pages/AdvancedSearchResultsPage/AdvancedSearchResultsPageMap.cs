using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage
{
    public partial class AdvancedSearchResultsPage
    {
        public Element Result1 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[1]"));
        public Element Result2 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[2]"));
        public Element Result3 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[3]"));
        public Element Result4 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[4]"));
        public Element Result5 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[5]"));
        public Element Result6 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[6]"));
        public Element Result7 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[7]"));
        public Element Result8 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[8]"));
        public Element Result9 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[9]"));
        public Element Result10 => Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[10]"));
    }
}
