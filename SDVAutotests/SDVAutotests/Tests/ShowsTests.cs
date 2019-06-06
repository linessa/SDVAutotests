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
                page.ClickOnShowByText("New on NBC");
        }

        [Test]
        public void ActorsTest()
        {
            int expectedActorsNumber = 7;
            var page = new MainNBCPage(_driver)
                .OpenMainPage()
                .OpenShowsPage();

            Assert.That(page.IsElementsOnPageByText("The Blacklist"), Is.True, "Нет сериала The Blacklist на вкладке Shows");

            var showPage = page.ClickOnShowByText("The Blacklist")
                    .AddToFavorite()
                    .CloseSingUpWindow()
                    .OpenCastTab();

            Assert.That(showPage.CheckNumberOfActors(expectedActorsNumber), Is.True, $"Число актеров отличное от {expectedActorsNumber} на вкладке Cast");
            Assert.That(showPage.IsActorOnPageByName("James Spader"), Is.True, "Нет актера James Spader на вкладке Cast");
            Assert.That(showPage.IsActorOnPageByName("Mozhan Marnò"), Is.True, "Нет актера The Mozhan Marnò на вкладке Cast");
            Assert.That(showPage.IsActorOnPageByName("Hisham Tawfiq"), Is.True, "Нет актера Hisham Tawfiq на вкладке Cast");

            Assert.That(showPage
                .OpenAboutActor("Megan Boone")
                .ClickMoreButton()
                .IsLessButtonDisplayed(), Is.True, "Нет кнопки Less");
            

        }

        [OneTimeTearDown]
        public void DeleteDriver()
        {
            _driver.Quit();
        }
    }
}
