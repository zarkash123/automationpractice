using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace automationpractice.Classes.SignIn
{
    [TestClass]
   
    public  class SignInSignUpPageTestCase:CorePage
    {
        
        SignInSignUpPage s = new SignInSignUpPage();
        ExtentTest test = null;
        ExtentReports extent = new ExtentReports();
        //[ClassInitialize()]

        //public void classInit() { }

        //[ClassCleanup()]
        //public void classCleanup() { }


        [AssemblyInitialize()]

        public static void AssemblyInit(TestContext testContext)
        {

            SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");

        }

        [AssemblyCleanup()]

        public static void AssemblyClean()
        {
            driver.Close();
        }


        [TestMethod]
        public void login_TC01()
        {
            test = extent.CreateTest("login_TC01").Info("Test Started");
            s.login("zarmeenkashif@gmail.com", "zarmeen123");  // for pass testcase
            s.signout();


        }

        [TestMethod]
        public void login_TC02()
        {
            test = extent.CreateTest("login_TC02").Info("login fail testcase Started");
            s.login("abcdf", "5678");  // for fail testcase
           // s.signout();

        }

        [TestMethod]
        public void signUp_TC03()
        {

            test = extent.CreateTest("signUp_TC03").Info("SignUp started");
            s.signup("saira@gmail.com","saira","kashif","saira123","123","123","lhr","54700");       //for signup process
            s.verifyTitle("CREATE AN ACCOUNT"); // verify through assert
        }









    }
}
