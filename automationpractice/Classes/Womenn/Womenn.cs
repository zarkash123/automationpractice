using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using automationpractice.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace automationpractice.Classes.Womenn
{
    public partial class Womenn: CorePage
    {

        public void WomennBtn() 
        {
           

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(WomenBtn)).Perform();
            Thread.Sleep(2000);
            action.MoveToElement(driver.FindElement(WomenTop)).Perform();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            
            //driver.FindElement(WTtshirts).Click();
            //switch (subMenu){

            //    case "Tshirts":
            //    driver.FindElement(WTtshirts).Click();
            //    break;

            //    case "Blouses":
            //    driver.FindElement(WTblouses).Click();
            //    break;

            //    default:
            //    Console.WriteLine("not found");
            //    break;
            //}

            //return;

        }
    }
}
