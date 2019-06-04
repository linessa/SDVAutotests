using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SDVAutotests.Pages;

namespace SDVAutotests
{
    public class ShowsTests
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void CreateDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenAllShowsTabsTest()
        {
            new MainNBCPage(_driver)
                .OpenMainPage()
                .OpenShowsPage()
                .OpenCurrentTab()
                .OpenThrowbackTab()
                .OpenUpcomingTab()
                .OpenAllTab();
        }

        [Test]
        public void ClickOnElementByTextTest()
        {
            var page = new MainNBCPage(_driver)
                .OpenMainPage()
                .OpenShowsPage();

            if (page.IsElementsOnPageByText("New on NBC"))
                page.ClickOnElementByText("New on NBC");
        }

        [OneTimeTearDown]
        public void DeleteDriver()
        {
            _driver.Quit();
        }
    }
}
