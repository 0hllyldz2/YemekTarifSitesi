using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Kullanici : System.Web.UI.MasterPage

{
    SQLsinifi bgl = new SQLsinifi();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand komur = new SqlCommand("SELECT * FROM Tbl_Kategoriler", bgl.baglanti());
        SqlDataReader oku = komur.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();
    }
}
