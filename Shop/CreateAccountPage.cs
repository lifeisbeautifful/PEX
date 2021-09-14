using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class CreateAccountPage
    {
        IWebDriver Driver { get; set; }
        public CreateAccountPage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        IWebElement firstNameField => Driver.FindElement(By.Id("customer_firstname"));
        IWebElement lastNameField => Driver.FindElement(By.Id("customer_lastname"));
        IWebElement emailField => Driver.FindElement(By.Id("email"));
        IWebElement passwordField => Driver.FindElement(By.Id("passwd"));
        IWebElement addressFirstName => Driver.FindElement(By.Id("firstname"));
        IWebElement addressLastName => Driver.FindElement(By.Id("lastname"));
        IWebElement addressField => Driver.FindElement(By.Id("address1"));
        IWebElement cityField => Driver.FindElement(By.Id("city"));
        IWebElement stateField => Driver.FindElement(By.Id("id_state"));
        IWebElement zipCode => Driver.FindElement(By.Id("postcode"));
        IWebElement phoneMobile => Driver.FindElement(By.Id("phone_mobile"));
        IWebElement assignAddress => Driver.FindElement(By.Id("alias"));
        
        public void SetValues(params string[]inputs )
        {
            firstNameField.SendKeys(inputs[0]);
            lastNameField.SendKeys(inputs[1]);
            passwordField.SendKeys(inputs[2]);
            addressField.SendKeys(inputs[3]);
            cityField.SendKeys(inputs[4]);
            zipCode.SendKeys(inputs[5]);
            phoneMobile.SendKeys(inputs[6]);
            assignAddress.Clear();
            assignAddress.SendKeys(inputs[7]);
        }
       
        public bool CheckEmail(string email)
        {
            return emailField.GetAttribute("value") == email;
        }
        public void SelectCountry()
        {
            IWebElement countryField = Driver.FindElement(By.Id("id_country"));
            countryField.Click();
            countryField.SendKeys(Keys.Enter);
        }
        public void SetState()
        {
            IWebElement stateField = Driver.FindElement(By.Id("id_state"));
            stateField.SendKeys("Tex");
            stateField.SendKeys(Keys.Enter);
        }

        public void SetBirthData()
        {
            IWebElement dayOfBirth = Driver.FindElement(By.Id("days"));
            dayOfBirth.Click();
            dayOfBirth.SendKeys(Keys.Down);
            dayOfBirth.SendKeys(Keys.Enter);

            IWebElement monthOfBirth = Driver.FindElement(By.Id("months"));
            monthOfBirth.SendKeys("April");

            IWebElement yearOfBirth = Driver.FindElement(By.Id("years"));
            yearOfBirth.SendKeys("1990");
        }
        public bool checkReceiveCheckbox()
        {
            IWebElement receive = Driver.FindElement(By.Id("optin"));
            receive.Click();

            //IWebElement checkedBox= Driver.FindElement(By.XPath("//div[@id='uniform-optin']//span[@class='checked']"));
            return receive.Selected;
        }
    }
}
