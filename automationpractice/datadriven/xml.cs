using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace automationpractice.datadriven
{
    [TestClass]
    public class xml : CorePage
    {

        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "user", DataAccessMethod.Sequential)]
        public void datadrivenxml() 
        {
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow[0].ToString());
            driver.FindElement(By.Id("passwd")).SendKeys(TestContext.DataRow[1].ToString());
            driver.FindElement(By.Id("SubmitLogin")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
            //Thread.Sleep(2000);
            driver.FindElement(By.ClassName("logout")).Click();


        }

    }
}
