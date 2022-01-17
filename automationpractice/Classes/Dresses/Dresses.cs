using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium.Interactions;

namespace automationpractice.Classes.Dresses
{
    public partial class Dresses : CorePage
    {
        public void DressesBtn()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(Dresses_Btn)).Perform();
            Thread.Sleep(1000);


        }

    }
}
