using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SimeonGenov_TaskATP.Pages.InfoPage;
using System.Threading;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage
{
    public partial class AdvancedSearchResultsPage : BasePage
    {
        public AdvancedSearchResultsPage(Driver driver) 
            : base(driver)
        {
        }

        public List<string> ExtractLinks()
        {
            
            var list = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                var element = Driver.FindElement(By.XPath("(//a[starts-with(@href, '/zip-code/')])[" + i +"]"));
                list.Add(element.GetAttribute("href"));
            }
            return list;
        }
    }
}
