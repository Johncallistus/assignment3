using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace TestSelenium
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method");
            //Method - url, click etc
            //chromedriver.exe  for chrome browser
            //v94  .exe v94 if version changes need update ChromeDriver.exe
            //
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());      
            //driver = new EdgeDriver();
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
              driver = new ChromeDriver();

            //driver = new FirefoxDriver();


            driver.Manage().Window.Maximize();
        }

        
        public void Test1()
        {
            //Assert.Pass();
            TestContext.Progress.WriteLine("Test1 method");
            driver.Navigate().GoToUrl("http://localhost/triangleSolver/");
            driver.Manage().Window.Size = new System.Drawing.Size(1073, 816);
            driver.FindElement(By.Id("firstSide")).Click();
            driver.FindElement(By.Id("firstSide")).SendKeys("4");
            driver.FindElement(By.CssSelector(".card > div:nth-child(2)")).Click();
            driver.FindElement(By.Id("secondSide")).Click();
            driver.FindElement(By.Id("secondSide")).SendKeys("4");
            driver.FindElement(By.Id("thirdSide")).Click();
            driver.FindElement(By.Id("thirdSide")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Thread.Sleep(10);
            string actual = driver.FindElement(By.Id("triangleType")).Text;
            string actual1 = driver.FindElement(By.XPath("//input[@name='triangleType']")).Text;
            string expected = "Equilateral triangle";
            TestContext.Progress.WriteLine(actual1+"\n"+actual); 
            //Assert.AreEqual(expected, actual);
            Assert.That(actual1, Is.EqualTo(expected));
        }
 //       [Test]
        //public void Test2()
        //{
        //    //Assert.Pass();
        //    TestContext.Progress.WriteLine("Test2 method");
        //}

        [TearDown]
        public void Close()
        {
            TestContext.Progress.WriteLine("Close method");
            //driver.Quit();
            driver.Close();
        }
    }
}