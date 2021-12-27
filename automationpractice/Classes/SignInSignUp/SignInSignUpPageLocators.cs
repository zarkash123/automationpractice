using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium;

namespace automationpractice.Classes.SignIn
{
    public partial class SignInSignUpPage
    {
        // signin locators
        By Signinbutton = By.ClassName("login");
        By useremail = By.Id("email");
        By userpassword = By.Id("passwd");
        By Loginbutton = By.Name("SubmitLogin");
        




        //signout locators

        By UserOut = By.XPath("//a[contains(text(),'Sign out')]");

        // signup locators

        By SignupId = By.Id("email_create");
        By SignUpClick = By.Id("SubmitCreate");
        By SuccessfulSignup = By.XPath("//h1[text()='Create an account']");
        By radio1 = By.XPath("//input[@id='id_gender1']");
        By radio2 = By.Id("id_gender2");
        By fname = By.XPath("//input[@id='customer_firstname']");
        By lname = By.XPath("//input[@id='customer_lastname']");
        By setPassword = By.XPath("//input[@id='passwd']");
        By setAddress1 = By.Id("address1");
        By setAddress2 = By.Id("address2");
        By setCity = By.Id("city");
        By setPostalCode = By.Id("postcode");
        By setMobilePhone = By.Name("phone_mobile");
        By ClickRegister = By.XPath("//span[contains(text(),'Register')]");

    }
}
