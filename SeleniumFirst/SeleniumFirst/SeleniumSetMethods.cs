using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebDriver driver, string elementType, string element, string value)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // Click into a button, checkbox, option, etc.
        public static void ClickElement(IWebDriver driver, string elementType, string element)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }

        // Select a dropdown control
        public static void SelectDropDown(IWebDriver driver, string elementType, string element, string value)
        {
            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }

            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }

        }
    }
}
