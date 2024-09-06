using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V126.Storage;

namespace SeleniumCSharpHttpCat.Pages
{
    public class InfoCatPage
    {
        private readonly IWebDriver driver;

        public InfoCatPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        string xPathH1Element => "//h1[@class='text-center my-12']";
        string xPathReturnToHome => "//a[@href='/']";
       
        IWebElement h1Element => driver.FindElement(By.XPath(xPathH1Element));
        
        IWebElement returnHome => driver.FindElement(By.XPath(xPathReturnToHome));
        

        public void ClickOnHome()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPathReturnToHome)));
            returnHome.Click();
        }

        public string GetH1Text()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPathH1Element)));
            return h1Element.Text;
        }

       
    }
}
