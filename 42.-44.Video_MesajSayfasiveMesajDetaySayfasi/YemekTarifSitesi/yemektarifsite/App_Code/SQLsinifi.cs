using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Drawing;


//Data Source = DESKTOP - U5BN37L\SQLEXPRESS; Initial Catalog = dbo_yemektarifi; Integrated Security = True; Trust Server Certificate=True
public class SQLsinifi
{
    public SqlConnection baglanti()
    {
       SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-U5BN37L\SQLEXPRESS;Initial Catalog=dbo_yemektarifi;Integrated Security=True;TrustServerCertificate=True;");
        baglan.Open();
        return baglan;
    }
}