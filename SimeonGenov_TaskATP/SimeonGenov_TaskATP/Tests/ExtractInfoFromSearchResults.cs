using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using SimeonGenov_TaskATP.Pages.HomePage;
using SimeonGenov_TaskATP.Pages.SearchPage;
using SimeonGenov_TaskATP.Pages.AdvancedSearchPage;
using SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage;
using SimeonGenov_TaskATP.Pages.InfoPage;
using SimeonGenov_TaskATP.Helpers;
using System.Collections.Generic;

namespace SimeonGenov_TaskATP.Tests
{
    [TestClass]
    public class ExtractInfoFromSearchResults
    {
        private static Driver _driver;
        private static HomePage _homePage;
        private static SearchPage _searchpage;
        private static AdvancedSearchPage _advancedSearchPage;
        private static AdvancedSearchResultsPage _advancedSearchResultsPage;
        private static InfoPage _infoPage;


        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            CreateScreenshotsDirectory();

            _driver = new WebDriver();
            _driver.Start(Browser.Chrome);

            _homePage = new HomePage(_driver);
            _searchpage = new SearchPage(_driver);
            _advancedSearchPage = new AdvancedSearchPage(_driver);
            _advancedSearchResultsPage = new AdvancedSearchResultsPage(_driver);
            _infoPage = new InfoPage(_driver);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _driver.Quit();
        }
        [TestMethod]
        public void ScreenshotFirstTenResultsWithNameLetters()
        {
            _homePage.NavigateTo();
            _homePage.GoToSearch();
            _searchpage.GoToAdvancedSearch();
            _advancedSearchPage.ClickTownField();
            _advancedSearchPage.FillTownField("sim");
            _advancedSearchPage.ClickFindZIPCodesButton();
            GoThroughLinks(ExctractLinks());
        }

        private List<string> ExctractLinks()
        {
            var links = new List<string>();
            List<Element> elements = _advancedSearchResultsPage.Results;
            foreach (var element in elements)
            {
                links.Add(element.GetAttribute("href"));
            }
            return links;
        }

        private void GoThroughLinks(List<string> links)
        {
            for (int i = 0; i < 9; i++)
            {
                _driver.GoToUrl(links[i]);
                _infoPage.OpenGoogleMapsURL();
                _driver.NavigateBack();
                _driver.NavigateBack();
            }
        }

        private static void CreateScreenshotsDirectory()
        {
            string path = @"..\..\..\Screenshots";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}