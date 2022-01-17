using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace automationpractice.Classes.Cart
{
    [TestClass]
    public class CartTestCase:CorePage
    {

    Cart c = new Cart();

        

   [TestMethod]

        public void CartBtn_TC01()
        {

            c.CartBuuton("1","M","White");
        }





    }
}
