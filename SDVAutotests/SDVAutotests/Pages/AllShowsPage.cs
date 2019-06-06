using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVAutotests.Pages
{
    class AllShowsPage : Page
    {
        private static string _lnkAllTab = "a[href='/shows/all']";
        private static string _lnkCurrentTab = "a[href='/shows/current']";
        private static string _lnkUpcomingTab = "a[href='/shows/upcoming']";
        private static string _lnkThrowbackTab = "a[href='/shows/classic-throwback']";
        private static string _lnkAddToFavorite = "li.navigation__item__desktop-only a.navigation__item__link--favorite-add";
        private static string _lnkCloseSingUpWindow = "span[href='#']";

        public AllShowsPage(IWebDriver driver) : base(driver) { }

        public AllShowsPage OpenAllTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkAllTab))).Click();
            return this;
        }

        public AllShowsPage OpenCurrentTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkCurrentTab))).Click();
            return this;
        }

        public AllShowsPage OpenUpcomingTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkUpcomingTab))).Click();
            return this;
        }

        public AllShowsPage OpenThrowbackTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkThrowbackTab))).Click();
            return this;
        }

        public ShowPage ClickOnShowByText(string text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(text))).Click();
            return new ShowPage(driver);
        }

        public bool IsElementsOnPageByText(string text)
        {
            return wait.Until((IWebDriver d) => driver.FindElements(By.PartialLinkText(text)).Count() > 0);
        }
    }
}
