﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DropdownListTitleIdElement { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement InitialElement { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstNameElement { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddleNameElement { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement ButtonSaveElement { get; set; }

        public void FillUserForm(string initial, string firstName, string middleName)
        {
            InitialElement.EnterText(initial);
            FirstNameElement.EnterText(firstName);
            MiddleNameElement.EnterText(middleName);
            ButtonSaveElement.ClickElement();
        }
    }
}
