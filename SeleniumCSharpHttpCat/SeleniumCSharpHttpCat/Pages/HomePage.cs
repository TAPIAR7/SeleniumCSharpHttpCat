using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpHttpCat.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnCatImage(int statusCode)
        {
            IWebElement button = driver.FindElement(By.XPath("//a[@href='/status/" + statusCode + "']"));
            button.Click();
            
        }
        public void ClickOnHome()
        {
            IWebElement button = driver.FindElement(By.XPath("//a[@href='/']"));
            button.Click();
        }
    }
}
