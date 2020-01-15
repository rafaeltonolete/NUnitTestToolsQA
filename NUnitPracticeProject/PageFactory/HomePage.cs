
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnitPracticeProject.PageFactory
{
    public class HomePage
    {


        private static IWebElement element = null;




        public static IWebElement MyAccountLink(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath(".//*[contains(text(),'My Account')]"));
            return element;
        }




    }




}

