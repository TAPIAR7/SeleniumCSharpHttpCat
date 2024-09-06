using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpHttpCat.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        public int statusCodeNumber { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        string xPathStatusCodeElement => "//a[@href='/status/" + statusCodeNumber + "']";
        string tagNameUsage => "h2";
        IWebElement StatusCode => driver.FindElement(By.XPath(xPathStatusCodeElement));
        IWebElement h2Element => driver.FindElement(By.TagName(tagNameUsage));
        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public void ClickStatusCode()
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPathStatusCodeElement)));
            StatusCode.Click();
        }

        public string GetH2Text()
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(tagNameUsage)));
            return h2Element.Text;
        }
    }
}
