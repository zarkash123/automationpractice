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

namespace automationpractice.Classes.SignIn
{
    [TestClass]
   
    public  class SignInSignUpPageTestCase:CorePage
    {

        SignInSignUpPage s = new SignInSignUpPage();

        //[ClassinItialize()]

        //public void classinit() { }

        //[classcleanup()]
        //public void classcleanup() { }


        [AssemblyInitialize()]

        public static void AssemblyInit(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {

            SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");

        }

        [AssemblyCleanup()]

        public static void AssemblyClean()
        {
            driver.Close();
        }


        ExtentTest test = null;
        ExtentReports extent = new ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\report\extentreport\SigninSignup.html"); ;
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();

        }

        //[Test]
        [TestMethod]
        [TestCategory ("SignIn")]
        public void login_TC01()
        {

            test = extent.CreateTest("SignIn successfully").Info("Test Started");
            s.login("zarmeen@gmail.com", "zarmeen123");  // for pass testcase
            s.signout();
            test.Log(Status.Info, "Test case passed");


        }
        //[Test]
        [TestMethod]
        public void login_TC02()
        {

            test = extent.CreateTest("SignIn unsuccessfully").Info("Test Started");
            s.login("abcdf", "5678");  // for fail testcase
            test.Log(Status.Info, "Test case not passed");

        }
        //[Test]
        [TestMethod]
        public void signUp_TC03()
        {
            test = extent.CreateTest("SignUp successfully").Info("Test Started");
            s.signup("saira@gmail.com","saira","kashif","saira123","123","123","lhr","54700");       //for signup process
            s.verifyTitle("CREATE AN ACCOUNT"); // verify through assert
            test.Log(Status.Info, "Test case  passed");
        }









    }
}
