using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumExtras.WaitHelpers;

namespace automationpractice.Classes.SignIn
{
    public partial class SignInSignUpPage : CorePage
    {
        public object SeleniumExtras { get; private set; }

        public void login(string email, string password)
        {
            driver.FindElement(Signinbutton).Click();
            driver.FindElement(useremail).SendKeys(email);
            driver.FindElement(userpassword).SendKeys(password);
            driver.FindElement(Loginbutton).Click();
        }

        public void signout()
        {
           driver.FindElement(UserOut).Click();

        }

        public void signup(string email,string firstname,string lastname,string password, string address1 , string address2 , string city , string postalcode  )
        {
            driver.FindElement(Signinbutton).Click();
            driver.FindElement(SignupId).SendKeys(email);
            driver.FindElement(SignUpClick).Click();

            //wait condition
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement radio1 = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id='id_gender1']")));
            radio1.Click();



            driver.FindElement(fname).SendKeys(firstname);
            driver.FindElement(lname).SendKeys(lastname);
            driver.FindElement(setPassword).SendKeys(password);

            //dropdown menu

            IWebElement element = driver.FindElement(By.Id("days"));
            SelectElement oselect = new SelectElement(element);
            oselect.SelectByIndex(3);



            IWebElement elements = driver.FindElement(By.Id("months"));
            SelectElement oselects = new SelectElement(elements);
            oselects.SelectByIndex(3);



            IWebElement elementss = driver.FindElement(By.Id("years"));
            SelectElement oselectss = new SelectElement(elementss);
            oselectss.SelectByIndex(5);

            driver.FindElement(fname).SendKeys(firstname);
            driver.FindElement(lname).SendKeys(lastname);
            driver.FindElement(setAddress1).SendKeys(address1);
            driver.FindElement(setAddress2).SendKeys(address2);
            driver.FindElement(setCity).SendKeys(city);

            //state
            IWebElement element1 = driver.FindElement(By.Id("id_state"));
            SelectElement oselect1 = new SelectElement(element1);
            oselect1.SelectByValue("43");

            
            driver.FindElement(setPostalCode).SendKeys(postalcode);

            //country
            IWebElement element_country = driver.FindElement(By.Id("id_country"));
            SelectElement oselect_country = new SelectElement(element_country);
            oselect_country.SelectByValue("21");

            //driver.FindElement(setMobilePhone).SendKeys(mobilephone);

            //driver.FindElement(ClickRegister).Click();

        }
         
        public void verifyTitle(string expectedResult)
        {
            string actual_result = driver.FindElement(SuccessfulSignup).Text;
            Assert.AreEqual(expectedResult, actual_result);
            //Console.WriteLine(actual_result);

        }
        
        
        


    }
}
