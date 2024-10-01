using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExercise.PageObjects
{
    internal class HomePage
    {
        private readonly IWebDriver _driver = new ChromeDriver();
        private const string HomeUrl = "https://localhost:44399/";

        public string GoToHomePage()
        {
            //start the browser maximized
            _driver.Manage().Window.Maximize();

            //navigate to home page
            _driver.Navigate().GoToUrl(HomeUrl);

            //return the title so we can check if we're on the right page
            return _driver.Title;
        }
    }
}
