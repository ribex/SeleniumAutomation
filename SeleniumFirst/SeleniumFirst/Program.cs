using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create reference for our browser
            IWebDriver driver = new ChromeDriver();

            // Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the element (search box)
            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform operations
            element.SendKeys("Test the input");
            driver.Close();
        }
    }
}
