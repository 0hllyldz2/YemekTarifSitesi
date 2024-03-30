using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekDetay : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string yemekid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        yemekid = Request.QueryString["Yemekid"];
        SqlCommand komut = new SqlCommand("SELECT YemekAd FROM Tbl_Yemekler WHERE Yemekid=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", Convert.ToInt16(yemekid));
        SqlDataReader dr = komut.ExecuteReader();

        if (dr.Read())
        {
            Label3.Text = dr["YemekAd"].ToString();
        }
        bgl.baglanti().Close();

        //Tarifi Listeleme
        SqlCommand komut2 = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE Yemekid=@p2", bgl.baglanti());
        komut2.Parameters.AddWithValue("@p2", Convert.ToInt16(yemekid));
        SqlDataReader dr2 = komut2.ExecuteReader();
        DataList2.DataSource = dr2;
        DataList2.DataBind();
        bgl.baglanti().Close();

        //Yorumları Listeleme
        SqlCommand komut3 = new SqlCommand("SELECT * FROM Tbl_Yorumlar WHERE Yemekid=@p3", bgl.baglanti());
        komut3.Parameters.AddWithValue("@p3", Convert.ToInt16(yemekid));
        SqlDataReader dr3 = komut3.ExecuteReader();
        DataList3.DataSource = dr3;
        DataList3.DataBind();
        bgl.baglanti().Close();
    }
}