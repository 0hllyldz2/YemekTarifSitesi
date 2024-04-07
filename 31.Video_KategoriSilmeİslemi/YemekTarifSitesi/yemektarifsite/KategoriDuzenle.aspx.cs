using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KategoriAdminDetay : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["Kategoriid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kategoriler WHERE Kategoriid=@p1", bgl.baglanti());
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
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        id = Request.QueryString["Kategoriid"];
        SqlCommand komut2 = new SqlCommand("UPDATE Tbl_Kategoriler SET KategoriAd=@p1, KategoriAdet=@p2 WHERE Kategoriid=@p3", bgl.baglanti());
        komut2.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut2.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut2.Parameters.AddWithValue("@p3", id);
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}