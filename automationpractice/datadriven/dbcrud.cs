using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using automationpractice.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace automationpractice.datadriven
{
    [TestClass]
    public class dbcrud : CorePage
    {
        SqlConnection con = new SqlConnection("Data Source=CRLHL-KASHIZAR1\\MSSQL;Initial Catalog=DataDrivenTesting;Integrated Security=True");
        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=CRLHL-KASHIZAR1\\MSSQL;Initial Catalog=DataDrivenTesting;Integrated Security=True", "Credentials", DataAccessMethod.Sequential)]
        public void dbCrud()
        {
            SqlCommand cmd = new SqlCommand("insert into Credentials values('arhum@gmail.com','arhum123')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=CRLHL-KASHIZAR1\\MSSQL;Initial Catalog=DataDrivenTesting;Integrated Security=True", "Credentials", DataAccessMethod.Sequential)]

        public void dbupdate()
        {
            SqlCommand cmd = new SqlCommand("update Credentials set password='abdullah123' where email= 'abdullahkashif@gmail.com'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=CRLHL-KASHIZAR1\\MSSQL;Initial Catalog=DataDrivenTesting;Integrated Security=True", "Credentials", DataAccessMethod.Sequential)]

        public void dbdelete() 
        {
            SqlCommand cmd = new SqlCommand("delete from Credentials where email='abdullahkashif@gmail.com'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
