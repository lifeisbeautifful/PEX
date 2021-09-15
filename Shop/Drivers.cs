using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Drivers
    {
        //commit
        public IWebDriver Driver { get; set; }
        public void Navigate()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //Driver.Manage().Window.FullScreen();
        }
    }
}
