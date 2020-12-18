using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using System.IO;
using System.Reflection;
using SimeonGenov_TaskATP.Pages.HomePage;
using SimeonGenov_TaskATP.Pages.SearchPage;
using SimeonGenov_TaskATP.Pages.AdvancedSearchPage;
using SimeonGenov_TaskATP.Pages.AdvancedSearchResultsPage;
using SimeonGenov_TaskATP.Pages.InfoPage;

namespace SimeonGenov_TaskATP.Tests
{
    [TestClass]
    public class Test1
    {
        private static IWebDriver _driver;
        private static HomePage _homePage;
        private static SearchPage _searchpage;
        private static AdvancedSearchPage _advancedSearchPage;
        private static AdvancedSearchResultsPage _advancedSearchResultsPage;
        private static InfoPage _infoPage;


        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _driver = new FirefoxDriver(Environment.CurrentDirectory);

            _homePage = new HomePage(_driver);
            _searchpage = new SearchPage(_driver);
            _advancedSearchPage = new AdvancedSearchPage(_driver);
            _advancedSearchResultsPage = new AdvancedSearchResultsPage(_driver);
            _infoPage = new InfoPage(_driver);


            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("start-maximized");
            //_driver = new ChromeDriver(path, options);


        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _driver.Quit();
        }


        [TestMethod]
        public void TestZipCodes()
        {
            _homePage.NavigateTo();
            _homePage.GoToSearch();
            _searchpage.GoToAdvancedSearch();
            _advancedSearchPage.ClickTownField();
            _advancedSearchPage.FillTownField("sim");
            _advancedSearchPage.ClickFindZIPCodesButton();

            // Looping through a list called "Results", containing all 10 entries, lead to an error (finding the elements)

            _advancedSearchResultsPage.ClickResult1();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult2();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult3();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult4();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult5();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult6();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult7();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult8();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult9();
            OpenInfoAndGoBack();

            _advancedSearchResultsPage.ClickResult10();
            OpenInfoAndGoBack();
        }
    
        public void OpenInfoAndGoBack()
        {
            _infoPage.OpenGoogleMapsURL();
            _driver.Navigate().Back();
            _driver.Navigate().Back();

        }   

    }
}