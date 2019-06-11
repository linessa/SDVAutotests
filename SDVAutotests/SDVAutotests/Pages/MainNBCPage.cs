using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVAutotests.Pages
{
    class MainNBCPage : Page
    {
        private static string _lnkShows = "a[href='/shows']";
        private static string _lnkEpisodes = "a[href='/video']";
        private static string _lnkShedule = "a[href='/schedule']";
        private static string _btnSports = "//span[contains(text(),'Sports')]/..";
        private static string _lnkShop = "a[href='https://www.nbcstore.com/?cid=nbc_global_nav_shop']";
        private static string _lnkApp = "a[href='/apps']";
        private static string _btnSearch = "li button.navigation__search";
        

        public MainNBCPage(IWebDriver driver) : base(driver) { }

        public MainNBCPage OpenMainPage()
        {
            driver.Navigate().GoToUrl("https://www.nbc.com/");
            return this;
        }

        public AllShowsPage OpenShowsPage()
        {
            WaitForElementPresent(By.CssSelector(_lnkShows)).Click();
            return new AllShowsPage(driver);
        }

        public MainNBCPage OpenEpisodesPage()
        {
            WaitForElementPresent(By.CssSelector(_lnkEpisodes)).Click();
            return this;
        }

        public MainNBCPage OpenShedulePage()
        {
            WaitForElementPresent(By.CssSelector(_lnkShedule)).Click();
            return this;
        }

        public MainNBCPage OpenSportsPage()
        {
            WaitForElementPresent(By.CssSelector(_btnSports)).Click();
            return this;
        }

        public MainNBCPage OpenShopPage()
        {
            WaitForElementPresent(By.CssSelector(_lnkShop)).Click();
            return this;
        }

        public MainNBCPage OpenAppPage()
        {
            WaitForElementPresent(By.CssSelector(_lnkApp)).Click();
            return this;
        }

        public MainNBCPage OpenSearchPage()
        {
            WaitForElementPresent(By.CssSelector(_btnSearch)).Click();
            return this;
        }
    }
}
