using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium.Support.UI;

namespace automationpractice.Classes.ContactUs
{
    public partial class ContactUs:CorePage
    {
        public void Contact(string heading, string email, string orderReference , string attachfile  ) 
        
        {

            driver.FindElement(ContactUsBtn).Click();
            
            SelectElement subjectHeading = new SelectElement(driver.FindElement(SubjectHeading));
            subjectHeading.SelectByText(heading);

            driver.FindElement(EmailBtn).SendKeys(email);
            Thread.Sleep(2000);
           
            driver.FindElement(ReferenceBtn).SendKeys(orderReference);

            driver.FindElement(AttachFile).SendKeys(attachfile);

            driver.FindElement(SubmitBtn).Click();
        }
    }
}
