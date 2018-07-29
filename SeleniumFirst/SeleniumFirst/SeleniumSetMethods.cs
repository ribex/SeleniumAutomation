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
        public static void EnterText(PropertyType elementType, string element, string value)
        {
            if (elementType == PropertyType.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // Click into a button, checkbox, option, etc.
        public static void ClickElement(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            }

            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
            }
        }

        // Select a dropdown control
        public static void SelectDropDown(PropertyType elementType, string element, string value)
        {
            if (elementType == PropertyType.Id)
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            }

            if (elementType == PropertyType.Name)
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
            }

        }
    }
}
