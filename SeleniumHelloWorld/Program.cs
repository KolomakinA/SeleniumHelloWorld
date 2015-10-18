using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://bing.com/");
            driver.Manage().Window.Maximize();

            IWebElement sString = driver.FindElement(By.Id("sb_form_q"));
            sString.SendKeys("Hello world");

            IWebElement sSubmit = driver.FindElement(By.Id("sb_form_go"));
            sSubmit.Click();

            driver.Close();


        }
    }
}
