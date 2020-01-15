using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnitPracticeProject.PageFactory;
using System.Threading;

namespace NUnitTest
{
    
    public class TestNUnitStyle
    {

        public IWebDriver driver;


        [SetUp]
        public void InitializeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Register()
        {

            driver.Navigate().GoToUrl("http://www.store.demoqa.com");

            Thread.Sleep(10000);

            //*[contains(@class,"dismiss-link")]

            try
            {
                driver.FindElement(By.XPath(".//*[contains(@class,'dismiss-link')]")).Click();
            }
            catch (Exception e)
            {
                throw e;
            }


            HomePage.MyAccountLink(driver).Click();

            LogInPageRegistrationPage.UserNameFieldReg(driver).SendKeys("TestUser_1");
            LogInPageRegistrationPage.EmailAddressReg(driver).SendKeys("TestUser_1@gmail.com");
            LogInPageRegistrationPage.PasswordFieldReg(driver).SendKeys("Test$&123");
            LogInPageRegistrationPage.RegisterButton(driver).Click();

        }


        [Test]
        public void LogIn()
        {
 
            driver.Navigate().GoToUrl("http://www.store.demoqa.com");

            Thread.Sleep(10000);

            var DismisLink = driver.FindElement(By.XPath(".//*[contains(@class,'dismiss-link')]"));

            try
            {
                DismisLink.Click();
            }
            catch (Exception e)
            {
                throw e;
            }

            HomePage.MyAccountLink(driver).Click();

            LogInPageRegistrationPage.UserNameField(driver).SendKeys("TestUser_1");
            LogInPageRegistrationPage.PasswordField(driver).SendKeys("Test@123");
            LogInPageRegistrationPage.LogInButton(driver).Click();

            //Assert.IsTrue();


        }

        [TearDown]
        public void CleanUp()
        {
            
            driver.Close();
            driver.Dispose();
        }


    }
}
