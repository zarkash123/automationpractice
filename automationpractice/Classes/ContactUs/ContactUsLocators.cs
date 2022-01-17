using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationpractice.Classes.ContactUs
{
    public partial class ContactUs
    {
        By ContactUsBtn = By.XPath("//a[@title='Contact Us']");

        By SubjectHeading = By.Id("id_contact");

        By EmailBtn = By.Id("email");

        By ReferenceBtn = By.Id("id_order");

        By AttachFile = By.Id("fileUpload");

        By SubmitBtn = By.XPath("//span[contains(text(),'Send')]");
    }
}
