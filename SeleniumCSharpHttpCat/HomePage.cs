using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
public class Class1
{
	public Homepage()
	{
		public void InitializeDriver()
		{
			try
			{
                IWebDriver driver = new ChromeDriver();
            }
			catch (global::System.Exception)
			{

				throw;
			}
            
        }

		public void NavigateToWebpage(string url)
		{

		}
	}
}
