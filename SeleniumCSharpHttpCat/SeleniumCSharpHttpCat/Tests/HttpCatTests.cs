using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpHttpCat.Pages;
using SeleniumCSharpHttpCat;

namespace SeleniumCSharpHttpCat.Tests
{
    [TestFixture]
    public class HttpCatTests
    {
        private ChromeDriver driver;
        private HomePage homePage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://http.cat/"); 
            homePage = new HomePage(driver);
        }
        [Test]
        public void TestClickOn100Cat()
        {
            homePage.ClickOnCatImage(100);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement h1Element = driver.FindElement(By.XPath("//h1[@class='text-center my-12']"));
            string h1Content = h1Element.Text;
            Assert.AreEqual("100 Continue", h1Content);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            homePage.ClickOnHome();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
        }


    }
}
