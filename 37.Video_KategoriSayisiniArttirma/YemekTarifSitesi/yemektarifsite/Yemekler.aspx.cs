using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Yemekler : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    protected void Page_Load(object sender, EventArgs e)
    {
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

        //Yemek Listesi
        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler", bgl.baglanti());
        SqlDataReader dr = komut.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();

        Panel2.Visible = false;
        Panel4.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {
        //Yemek Ekle
        SqlCommand komut3 = new SqlCommand("INSERT INTO Tbl_Yemekler (YemekAd, YemekMalzeme, YemekTarif, Kategoriid) VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());
        komut3.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut3.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut3.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut3.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        komut3.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Kategori Sayı Arttırma
        SqlCommand komut4 = new SqlCommand("UPDATE Tbl_Kategoriler SET KategoriAdet=KategoriAdet+1 WHERE Kategoriid=@p1", bgl.baglanti());
        komut4.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
        komut4.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}