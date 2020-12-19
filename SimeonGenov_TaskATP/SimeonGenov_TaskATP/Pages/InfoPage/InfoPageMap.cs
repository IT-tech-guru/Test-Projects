using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage
    {        
        public Element ZipCode => Driver.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[1]/td[2]"));
        public Element City => Driver.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[2]/td[2]"));
        public Element State => Driver.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[3]/td[2]"));
        public Element Longitude => Driver.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[13]/td[2]"));
        public Element Latitude => Driver.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[14]/td[2]"));
    }
}
