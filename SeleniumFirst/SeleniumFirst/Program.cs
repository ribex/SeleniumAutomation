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
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            // Navigate to Execute Automation demo page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Initialize the page by calling its reference
            EAPageObject page = new EAPageObject();

            page.InitialElement.SendKeys("execute automation");

            page.ButtonSaveElement.Click();


            //// TitleId
            //SeleniumSetMethods.SelectDropDown(PropertyType.Id, "TitleId", "Mr.");

            //// Initial
            //SeleniumSetMethods.EnterText(PropertyType.Name, "Initial", "execute automation");

            //// Get the title value
            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDropdownList(PropertyType.Id, "TitleId"));

            //// Get the initial value
            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(PropertyType.Name, "Initial"));

            //// Click
            //SeleniumSetMethods.ClickElement(PropertyType.Name, "Save");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
