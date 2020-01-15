using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnitPracticeProject.PageFactory
{
    public class LogInPageRegistrationPage
    {

        public static IWebElement element = null;
        

        //LogIn 
        public static IWebElement UserNameField(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//input[contains(@id,'username')]"));
            return element;
        }

        public static IWebElement PasswordField(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//input[contains(@id,'password')]"));
            return element;
        }

        public static IWebElement LogInButton(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//button[contains(text(),'Log in')]"));
            return element;
        }



        //Registration

        public static IWebElement UserNameFieldReg(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//input[contains(@id,'reg_username')]"));
            return element;
        }

        public static IWebElement EmailAddressReg(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//input[contains(@id,'reg_email')]"));
            return element;
        }


        public static IWebElement PasswordFieldReg(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//input[contains(@id,'reg_password')]"));
            return element;
        }

        public static IWebElement RegisterButton(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//button[contains(text(),'Register')]"));
            return element;
        }



    }
}
