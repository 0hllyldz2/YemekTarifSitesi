using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YorumDetay : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["Yorumid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("SELECT YorumAdSoyad, YorumMail, Yorumİcerik, YemekAd FROM Tbl_Yorumlar INNER JOIN Tbl_Yemekler ON Tbl_Yorumlar.Yemekid=Tbl_Yemekler.Yemekid WHERE Yorumid=@p1", bgl.baglanti());
            if (string.IsNullOrEmpty(id))
            {
                komut.Parameters.AddWithValue("@p1", DBNull.Value);
            }
            else
            {
                komut.Parameters.AddWithValue("@p1", id);
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[0].ToString();
                TxtMail.Text = dr[1].ToString();
                TxtIcerik.Text = dr[2].ToString();
                TxtYemek.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void BtnOnay_Click(object sender, EventArgs e)
    {
        id = Request.QueryString["Yorumid"];
        SqlCommand komut2 = new SqlCommand("UPDATE Tbl_Yorumlar SET Yorumİcerik=@p1, YorumOnay=@p2 WHERE Yorumid=@p3", bgl.baglanti());
        komut2.Parameters.AddWithValue("@p1", TxtIcerik.Text);
        komut2.Parameters.AddWithValue("@p2", true);
        komut2.Parameters.AddWithValue("@p3", id);
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}