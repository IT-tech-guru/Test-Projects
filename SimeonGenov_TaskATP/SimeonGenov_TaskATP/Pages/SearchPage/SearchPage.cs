using OpenQA.Selenium;

namespace SimeonGenov_TaskATP.Pages.SearchPage
{
    public partial class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public void GoToAdvancedSearch()
        {
            AdvancedSearchButton.Click();
        }
    }
}
