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

namespace automationpractice.Classes.Womenn
{
    [TestClass]
    
    public class WomennTestCases:CorePage
    {
        ExtentTest test = null;
        ExtentReports extent = new ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {
            //extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\report\extentreport\WomennTestCases.html"); ;
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();

        }

        Womenn w = new Womenn();

        //[Test]
        [TestMethod]
        
        public void WomennTC_01()
        {
            test = extent.CreateTest("Women Button is hovered").Info("Test Started");
            w.WomennBtn();
            test.Log(Status.Info, "Women Test Case is Passed");
        }

    }
}
