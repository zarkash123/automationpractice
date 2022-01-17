using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace automationpractice.Classes.ContactUs
{
    [TestClass]
   public class ClontactUsTestCase:CorePage
    {
        ContactUs CU = new ContactUs();

        [TestMethod]

        public void ContactUsTC_01() 
        
        {
            CU.Contact("Customer service", "zarmeen@gmail.com", "my order", "D:\\OneDrive - Constellation HomeBuilder Systems\\Documents\\testcases.xlsx");
        
        
        }

    }
}
