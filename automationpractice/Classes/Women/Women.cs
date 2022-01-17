using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace automationpractice.Classes.Women
{
    public partial class Women : CorePage
    { 

        public void WomenBtn()
       {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(WomenBtn1)).Perform();





       }
    }
}
