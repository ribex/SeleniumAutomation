using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string elementType, string element)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            else if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return String.Empty;
            }
        }

        public static string GetTextFromDropdownList(IWebDriver driver, string elementType, string element)
        {
            if (elementType == "Id")
            {
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else if (elementType == "Name")
            {
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return String.Empty;
            }
        }

    }
}
