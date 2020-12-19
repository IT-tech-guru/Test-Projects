using OpenQA.Selenium;
using SimeonGenov_TaskATP.Helpers;

namespace SimeonGenov_TaskATP.Pages.SearchPage
{
    public partial class SearchPage : BasePage
    {
        public SearchPage(Driver driver) 
            : base(driver)
        {
        }

        public void GoToAdvancedSearch()
        {
            AdvancedSearchButton.Click();
        }
    }
}
