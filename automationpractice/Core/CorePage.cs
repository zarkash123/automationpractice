using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace automationpractice.Core
{
    public class CorePage
    {
        public static IWebDriver driver { get; set; }
        public static IWebDriver SeleniumInitialization(string browser, string url)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Url = url;
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Url = url;
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Url = url;
                    break;
                default:
                    Console.WriteLine("No such browser find");
                    break;

            }
            return driver;


        }

        ExtentTest test = null;
        ExtentReports extent = new ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\kashizar\source\repos\automationpractice\automationpractice\report\CorePage.html"); ;
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();

        }
    }
}
