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
    }
}   