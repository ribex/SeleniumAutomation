using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumFirst
{
    class Program
    {
        // Create reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Find the element (search box)
            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform operations
            element.SendKeys("Test the input");

            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
