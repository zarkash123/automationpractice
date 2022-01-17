using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationpractice.Classes.Womenn
{
    public partial class Womenn
    {
        By WomenBtn = By.ClassName("sf-with-ul");

        By WomenTop = By.XPath("//a[@title='Tops']");

        By WTtshirts = By.XPath("//a[@title='T-shirts'][1]");

        By WTblouses = By.XPath("//a[@title='Blouses']");

        By WomenDresses = By.XPath("//a[@title='Dresses'][1]");

    }
}
