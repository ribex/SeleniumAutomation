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
        public static string GetText(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Id)
            {
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            else if (elementType == PropertyType.Name)
            {
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return String.Empty;
            }
        }

        public static string GetTextFromDropdownList(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Id)
            {
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else if (elementType == PropertyType.Name)
            {
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return String.Empty;
            }
        }

    }
}
