using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Shop
{
    public class Tests:Drivers
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void MoveToCreateAccount()
        {
            Navigate();

            HomePage homepage = new HomePage(Driver);
            homepage.clickSignIn();
            Assert.IsTrue(homepage.CreateAccPage());
            Assert.IsTrue(homepage.CreateAccount("a@mailforspam.com"));

            CreateAccountPage createAccount = new CreateAccountPage(Driver);
            createAccount.SetValues("Olena", "Olena", "password", "Naukova str.", "Lviv", "81400", "0971234567", "Sukhiv");
            createAccount.SelectCountry();
            createAccount.SetState();
            createAccount.checkReceiveCheckbox();
        }
      

    }
    }
