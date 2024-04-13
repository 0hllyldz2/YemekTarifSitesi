using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekDuzenle : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["Yemekid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE Yemekid=@p1", bgl.baglanti());
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
                TextBox3.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();

            if (Page.IsPostBack == false)
            {
                //Kategori Listesi
                SqlCommand komut2 = new SqlCommand("SELECT * FROM Tbl_Kategoriler", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();

                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "Kategoriid";
                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        id = Request.QueryString["Yemekid"];
        SqlCommand komut3 = new SqlCommand("UPDATE Tbl_Yemekler SET YemekAd=@p1, YemekMalzeme=@p2, YemekTarif=@p3, Kategoriid=@p4 WHERE Yemekid=@p5", bgl.baglanti());
        komut3.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut3.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut3.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut3.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        komut3.Parameters.AddWithValue("@p5", id);
        komut3.ExecuteNonQuery();
        bgl.baglanti().Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Tüm Yemeklerin Durumu False Yaptı
        SqlCommand komut4 = new SqlCommand("UPDATE Tbl_Yemekler SET Durum=0", bgl.baglanti());
        komut4.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Günün Yemeği için ID'ye göre True Yapsin
        string id = Request.QueryString["Yemekid"];

        SqlCommand komut5 = new SqlCommand("UPDATE Tbl_Yemekler SET Durum=1 WHERE Yemekid=@p1", bgl.baglanti());
        komut5.Parameters.AddWithValue("@p1", id);
        komut5.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}