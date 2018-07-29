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
            // Navigate to Execute Automation demo page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // TitleId
            SeleniumSetMethods.SelectDropDown(driver, "Id", "TitleId", "Mr.");

            // Initial
            SeleniumSetMethods.EnterText(driver, "Name", "Initial", "execute automation");
            Console.WriteLine("Enter Initial");

            // Click
            SeleniumSetMethods.ClickElement(driver, "Name", "Save");
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
