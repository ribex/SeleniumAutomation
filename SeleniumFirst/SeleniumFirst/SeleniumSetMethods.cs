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
        public static void EnterText(string elementType, string element, string value)
        {
            if (elementType == "Id")
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementType == "Name")
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // Click into a button, checkbox, option, etc.
        public static void ClickElement(string elementType, string element)
        {
            if (elementType == "Id")
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            }

            if (elementType == "Name")
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
            }
        }

        // Select a dropdown control
        public static void SelectDropDown(string elementType, string element, string value)
        {
            if (elementType == "Id")
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            }

            if (elementType == "Name")
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
            }

        }
    }
}
