using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVAutotests.Pages
{
    class ShowPage : Page
    {
        private static string _lnkAddToFavorite = "li.navigation__item__desktop-only a.navigation__item__link--favorite-add";
        private static string _lnkCloseSingUpWindow = "span[href='#']";
        private static string _lnkCastTab = "a[href='/the-blacklist/credits/cast']";
        private static string _lnkAllActors = "div.shelf__tiles a";
        private static string _btnMore = "div.bio__long-desc__more";
        private static string _btnLess = "span.bio__desc__more-text";

        private string _lnkActor(string text) => $"//span[contains(text(),'{text}')]/../../../../..";


        

        public ShowPage(IWebDriver driver) : base(driver) { }

        public ShowPage OpenCastTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkCastTab))).Click();
            return this;
        }

        //public ShowPage ClickOnElementByText(string text)
        //{
        //    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(text))).Click();
        //    return this;
        //}

        public bool IsActorOnPageByName(string actorName)
        {
            return wait.Until((IWebDriver d) => driver.FindElements(By.XPath(_lnkActor(actorName))).Count() > 0);
        }

        public ShowPage AddToFavorite()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkAddToFavorite))).Click();
            return this;
        }

        public ShowPage CloseSingUpWindow()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_lnkCloseSingUpWindow))).Click();
            return this;
        }

        public bool CheckNumberOfActors(int expectedNumber)
        {
            return wait.Until((IWebDriver d) => driver.FindElements(By.CssSelector(_lnkAllActors)).Count() == expectedNumber);
        }

        public ShowPage OpenAboutActor(string actorName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(_lnkActor(actorName)))).Click();
            return this;
        }

        public ShowPage ClickMoreButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(_btnMore))).Click();
            return this;
        }

        public bool IsLessButtonDisplayed()
        {
            return wait.Until((IWebDriver d) => driver.FindElements(By.CssSelector(_btnLess)).Count() > 0);
        }
    }
}
