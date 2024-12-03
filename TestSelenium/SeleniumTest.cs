using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace TestSelenium
{
    [TestFixture]
    public class SeleniumTest
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Url = "https://www.calculator.net/rent-calculator.html";

        }

        
        public void Test1()
        {
            //driver.Url = "https://dog.ceo/api/breeds/list/all";
            driver.FindElement(By.Id("income")).Clear();
            driver.FindElement(By.Id("income")).SendKeys("900000");
            driver.FindElement(By.Id("income")).Clear();
            driver.FindElement(By.Id("income")).SendKeys("500000");
            driver.FindElement(By.Name("monthlydebt")).Clear();
            driver.FindElement(By.Name("monthlydebt")).SendKeys("1500");

            //driver.FindElement(By.XPath, //input[@Attribute=’calculate’]);

            driver.FindElement(By.Name("x")).Click();


            String actualDestinationURL = driver.Url;
            String expectedDestinationURl = "https://www.calculator.net/rent-calculator.html?income=500%2C000&incomeunit=y&monthlydebt=1%2C500&x=Calculate";

            Assert.That(actualDestinationURL, Is.EqualTo(expectedDestinationURl));
        }


        [TearDown]
        public void Close()
        {
            //driver.Close();
         //  driver.Quit();

        }
    }
}
