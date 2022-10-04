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

            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.XPath("//div[@class='FPdoLc lJ9FBc']//center//input[@name='btnK']");
            By googleResult = By.XPath("//h3[text()='Stack Overflow - Where Developers Learn, Share, & Build ...']");


            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);

            webdriver.Navigate().GoToUrl("https://www.google.lk/");
            Thread.Sleep(waitingTime);

            webdriver.FindElement(googleSearchBar).SendKeys("stack overflow");

            webdriver.FindElement(googleSearchButton).Click();
            Thread.Sleep(waitingTime);

            webdriver.FindElement(googleResult).Click();
            Thread.Sleep(waitingTime);


            webdriver.Quit();
        }
    }
}
