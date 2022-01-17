using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace automationpractice.datadriven
{
    [TestClass]
    public class DatadrivenSQL : CorePage
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=CRLHL-KASHIZAR1\\MSSQL;Initial Catalog=DataDrivenTesting;Integrated Security=True", "Credentials1", DataAccessMethod.Sequential)]

     public void datadrivensql()
        {
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow[0].ToString());
            driver.FindElement(By.Id("passwd")).SendKeys(TestContext.DataRow[1].ToString());
            driver.FindElement(By.Id("SubmitLogin")).Click();
            //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Sql.png", ScreenshotImageFormat.Png);
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@title='Log me out']")).Click();


        }

    } 
}
