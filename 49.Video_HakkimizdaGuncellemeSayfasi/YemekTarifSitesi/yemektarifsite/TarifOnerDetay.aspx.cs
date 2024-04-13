using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class TarifOnerDetay : System.Web.UI.Page
{
    SQLsinifi bgl = new SQLsinifi();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["Tarifid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Tarifler WHERE Tarifid=@p1", bgl.baglanti());
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
                TextBox4.Text = dr[5].ToString();
                TextBox5.Text = dr[6].ToString();
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

    protected void Button2_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["Tarifid"];

        //Güncelleme İşlemi
        SqlCommand komut3 = new SqlCommand("UPDATE Tbl_Tarifler SET TarifDurum=1 WHERE Tarifid=@p1", bgl.baglanti());
        komut3.Parameters.AddWithValue("@p1", id);
        komut3.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Yemekleri Ana Sayfaya Ekleme
        SqlCommand komut4 = new SqlCommand("INSERT INTO Tbl_Yemekler (YemekAd, YemekMalzeme, YemekTarif, Kategoriid) VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());
        komut4.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut4.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut4.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut4.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        komut4.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Kategori Sayı Arttırma
        SqlCommand komut5= new SqlCommand("UPDATE Tbl_Kategoriler SET KategoriAdet=KategoriAdet+1 WHERE Kategoriid=@p1", bgl.baglanti());
        komut5.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
        komut5.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}