using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SDVAutotests
{
    public class SampleClass
    {
        [Test]
        public void SampleClassTest()
        {
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        public void OpenNBCTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.nbc.com/");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Quit();
        }
    }
}
