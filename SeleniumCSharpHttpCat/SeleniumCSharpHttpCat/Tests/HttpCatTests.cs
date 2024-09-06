using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumCSharpHttpCat.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumCSharpHttpCat;

namespace SeleniumCSharpHttpCat.Tests
{
    [TestFixture]
    public class HttpCatTests
    {
        private ChromeDriver driver;
        private HomePage homePage;
        private InfoCatPage infoCatPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://http.cat/");
            homePage = new HomePage(driver);
            infoCatPage = new InfoCatPage(driver);
        }
        [Test]
        public void TestClickOn100Cat()
        {
            homePage.statusCodeNumber = 100;
            string expectedH1 = homePage.statusCodeNumber + " Continue";
            homePage.ClickStatusCode();
            Assert.AreEqual(expectedH1, infoCatPage.GetH1Text());
 
        }
        
        [Test]
        public void TestClickOn101Cat()
        {
            homePage.statusCodeNumber = 101;
            string expectedH1 = homePage.statusCodeNumber + " Switching Protocols";
            homePage.ClickStatusCode();
            Assert.AreEqual(expectedH1, infoCatPage.GetH1Text());

        }
        [Test]
        public void TestReturnHome()
        {
            homePage.statusCodeNumber = 100;
            string expectedH1 = homePage.statusCodeNumber + " Continue";
            string expectedH2 = "Usage:";
            homePage.ClickStatusCode();
            Assert.AreEqual(expectedH1, infoCatPage.GetH1Text());
            infoCatPage.ClickOnHome();
            Assert.AreEqual(expectedH2, homePage.GetH2Text());
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
        }


    }
}
