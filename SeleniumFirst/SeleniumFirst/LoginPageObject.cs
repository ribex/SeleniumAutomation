using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UserNameElement { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordElement { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement ButtonLoginElement { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            // UserName
            UserNameElement.EnterText(userName);
            // Password
            PasswordElement.EnterText(password);
            // Click submit button
            ButtonLoginElement.ClickElement();

            // Return the page object
            return new EAPageObject();
        }
    }
}
