using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace automationpractice.Classes.Dresses
{
    [TestClass]
    public  class DressesTestCases : CorePage 
    {
        ExtentTest test = null;
        ExtentReports extent = new ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\report\extentreport\Dresses.html"); ;
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();

        }
        Dresses d = new Dresses();
       
        [Test]
        [TestMethod]
        public void DressesBtnTC01()
        {
            test = extent.CreateTest("Dress Button pressed").Info("Test Started");
            d.DressesBtn();
            test.Log(Status.Info, "Test case passed");


        }

       
    }
}
