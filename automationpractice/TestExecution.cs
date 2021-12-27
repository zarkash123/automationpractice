//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using RestSharp;

//namespace automationpractice
//{

//    [TestClass]
//    public class TestExecution : TestMethod
//    {
//        [AssemblyInitialize()]

//        public static void assemblyInit(TestContext context)
//        {

//            SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");

//        }

//        [AssemblyCleanup()]

//        public static void assemblyClean()
//        {
//            driver.Close();
            

//        }




//        Method obj = new Method();
//        //private static object driver;

//        [TestMethod]

//        public void login_1()
//        {

           
//           login("zarmeenkashif@gmail.com", "zarmeen123");  // for pass testcase
//           signout();
           
//        }

//        [TestMethod]

//        public void Login_2()
//        {

            
//            login("abcdgh", "12345");  // for fail testcase
            
//        }


//    }
//}
