using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace automationpractice.Classes.Cart
{
   public partial class Cart : CorePage
    {
       
        public void CartBuuton(string quantity,string size,string color)
        {
            Actions action = new Actions(driver);

            action.MoveToElement(driver.FindElement(moveProduct)).Perform();
            Thread.Sleep(2000);
            
            driver.FindElement(MoreBtn).Click();

            driver.FindElement(QuantityRequired).Clear();
            driver.FindElement(QuantityRequired).SendKeys(quantity);

            SelectElement Size = new SelectElement(driver.FindElement(SelectSize));
            Size.SelectByText(size);

            driver.FindElement(selectColor(color)).Click();

            driver.FindElement(AddToCart).Click();


        }

        public By selectColor(string color)
        {
            if (color == "Black")
            {
                return BlackClr;
            }
            else
            {
                return whiteClr;
            }
        }

    }
}
