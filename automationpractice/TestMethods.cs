//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;

//namespace automationpractice
//{
//    public class TestMethod
//    {
//        public static IWebDriver driver { get; set; }
//        public static IWebDriver SeleniumInitialization(string browser, string url)
//        {
//            switch (browser)
//            {
//                case "Chrome":
//                    driver = new ChromeDriver();
//                    driver.Manage().Window.Maximize();
//                    driver.Url = url;
//                    break;
//                case "Firefox":
//                    driver = new FirefoxDriver();
//                    driver.Manage().Window.Maximize();
//                    driver.Url = url;
//                    break;
//                case "Edge":
//                    driver = new EdgeDriver();
//                    driver.Manage().Window.Maximize();
//                    driver.Url = url;
//                    break;
//                default:
//                    Console.WriteLine("No such browser find");
//                    break;

//            }
//            return driver;

//            //if (browser == "Chrome")
//            //{
//            //    driver = new ChromeDriver();
//            //    driver.Manage().Window.Maximize();
//            //    driver.Url = url;
//            //}
//            //else if (browser == "Edge")
//            //{
//            //    driver = new EdgeDriver();
//            //    driver.Manage().Window.Maximize();
//            //    driver.Url = url;
//            //}
//            //else if (browser == "Firefox")
//            //{
//            //    driver = new FirefoxDriver();
//            //    driver.Manage().Window.Maximize();
//            //    driver.Url = url;

//            //}
//            //return driver;



//        }

//        public void login(string email, string password)
//        {
//            driver.FindElement(By.ClassName("login")).Click();
//            driver.FindElement(By.Id("email")).SendKeys(email);
//            driver.FindElement(By.Name("passwd")).SendKeys(password);
//            driver.FindElement(By.Name("SubmitLogin")).Click();
//        }

//        public void signout()
//        {
//            driver.FindElement(By.XPath("//a[contains(text(),'Sign out')]")).Click();

//        }

       


//    }
//}
