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
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // Click into a button, checkbox, option, etc.
        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        // Select a dropdown control
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
