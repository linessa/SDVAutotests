using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVAutotests.Pages
{
    class ShowsPage : Page
    {
        private static string _lnkAllTab = "a[href='/shows/all']";
        private static string _lnkCurrentTab = "a[href='/shows/current']";
        private static string _lnkUpcomingTab = "a[href='/shows/upcoming']";
        private static string _lnkThrowbackTab = "a[href='/shows/classic-throwback']";

        public ShowsPage(IWebDriver driver) : base(driver) { }

        public ShowsPage OpenAllTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkAllTab))).Click();
            return this;
        }

        public ShowsPage OpenCurrentTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkCurrentTab))).Click();
            return this;
        }

        public ShowsPage OpenUpcomingTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkUpcomingTab))).Click();
            return this;
        }

        public ShowsPage OpenThrowbackTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkThrowbackTab))).Click();
            return this;
        }

        public ShowsPage ClickOnElementByText(string text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(text))).Click();
            return this;
        }

        public bool IsElementsOnPageByText(string text)
        {
            return wait.Until((IWebDriver d) => driver.FindElements(By.PartialLinkText(text)).Count() > 0);
        }
    }
}
