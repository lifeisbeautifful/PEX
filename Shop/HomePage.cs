using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shop
{
    public class HomePage
    {
        IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement signAn => Driver.FindElement(By.LinkText("Sign in"));
        IWebElement emailField => Driver.FindElement(By.Id("email_create"));
        IWebElement createBtn => Driver.FindElement(By.Id("SubmitCreate"));
        IWebElement signInForm => Driver.FindElement(By.Id("account-creation_form"));
        public void clickSignIn() => signAn.Click();
        public bool CreateAccPage() { return emailField.Displayed; }
        public bool CreateAccount(string email)
        {
            emailField.SendKeys(email);
            createBtn.Click();
            Thread.Sleep(20000);
            return signInForm.Displayed;
        }
    }
}
