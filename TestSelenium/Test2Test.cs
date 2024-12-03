﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Test2Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
       // driver.Quit();
    }
    [Test]
    public void test2()
    {
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
        string actual = driver.FindElement(By.Id("triangleType")).Text;
        string actual1 = driver.FindElement(By.XPath("//input[@name='triangleType']")).Text;
        string expected = "Equilateral triangle";
        TestContext.Progress.WriteLine(actual1 + "\n" + actual);
        //Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.EqualTo(expected));
        //Assert.That(vars["id=triangleType"].ToString(), Is.EqualTo("Equilateral triangle"));

        //driver.Close();



    }
}
