using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KategoriDetay : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string kategoriid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        kategoriid = Request.QueryString["Kategoriid"];
        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE Kategoriid=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", Convert.ToInt16(kategoriid));
        SqlDataReader dr = komut.ExecuteReader();
        DataList2.DataSource = dr;
        DataList2.DataBind();
        bgl.baglanti().Close();
    }
}