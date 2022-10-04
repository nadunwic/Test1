using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int waitingTime = 1000;

            By logInButton = By.XPath("//a[text()='Log in']");


            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);

            webdriver.Navigate().GoToUrl("https://stackoverflow.com/");
            Thread.Sleep(waitingTime);

            webdriver.FindElement(logInButton).Click();
            Thread.Sleep(waitingTime);

            webdriver.Quit();
        }
    }
}
