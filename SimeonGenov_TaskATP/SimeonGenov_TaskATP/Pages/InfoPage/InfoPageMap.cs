using OpenQA.Selenium;

namespace SimeonGenov_TaskATP.Pages.InfoPage
{
    public partial class InfoPage
    {        
        public IWebElement ZipCode => Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[1]/td[2]")));
        public IWebElement City => Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[2]/td[2]")));
        public IWebElement State => Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[3]/td[2]")));
        public IWebElement Longitude => Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[13]/td[2]")));
        public IWebElement Latitude => Wait.Until(d => d.FindElement(By.XPath("(//table[@class='statTable'])[1]/tbody/tr[14]/td[2]")));
    }
}
