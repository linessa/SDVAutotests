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

        public AllShowsPage(IWebDriver driver) : base(driver) { }

        public AllShowsPage OpenAllTab()
        {
            WaitForElementPresent(By.CssSelector(_lnkAllTab)).Click();
            return this;
        }

        public AllShowsPage OpenCurrentTab()
        {
            WaitForElementPresent(By.CssSelector(_lnkCurrentTab)).Click();
            return this;
        }

        public AllShowsPage OpenUpcomingTab()
        {
            WaitForElementPresent(By.CssSelector(_lnkUpcomingTab)).Click();
            return this;
        }

        public AllShowsPage OpenThrowbackTab()
        {
            WaitForElementPresent(By.CssSelector(_lnkThrowbackTab)).Click();
            return this;
        }

        public ShowPage ClickOnShowByText(string text)
        {
            WaitForElementPresent(By.PartialLinkText(text)).Click();
            return new ShowPage(driver);
        }

        public bool IsElementsOnPageByText(string text)
        {
            return IsElementDisplayed(By.PartialLinkText(text));
        }
    }
}
