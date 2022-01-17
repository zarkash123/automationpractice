using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationpractice.Classes.Cart
{
    public partial class Cart
    {
      
        By bt_Cart = By.XPath("//b[text()='Cart']");

        By btn_removeProduct = By.XPath("//a[@title='remove this product from my cart']");

        By btn_ProceedCheckOut = By.XPath("//a[@title='Proceed to checkout']");

        By btn_ContinueShopping = By.XPath("//a[@title='Continue shopping']");

        By moveProduct = By.XPath("//img[@title='Blouse']");

        By MoreBtn = By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[2]/div/div[2]/div[2]/a[2]/span");
        
        By QuantityRequired = By.Id("quantity_wanted");

        By SelectSize = By.Id("group_1");

        By whiteClr = By.Name("White");

        By BlackClr = By.Name("Black");

        By AddToCart = By.XPath("//span[contains(text(),'Add to cart')]");


    }
}
