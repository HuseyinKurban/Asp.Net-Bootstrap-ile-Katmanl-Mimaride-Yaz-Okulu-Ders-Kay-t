using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            DropDownList1.DataSource = BLLDers.BllListele();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();

            DropDownList2.DataSource = BLLOgrenci.BllListele();
            DropDownList2.DataTextField = "NUMARA";
            DropDownList2.DataValueField = "ID";
            DropDownList2.DataBind();
        }
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        EntityBasvuruForm ent = new EntityBasvuruForm();
        ent.BASOGRID = Convert.ToInt32(DropDownList2.SelectedValue);
        ent.BASDERSID =Convert.ToInt32( DropDownList1.SelectedValue);
        BLLDers.BLLTalepEkle(ent);
        Response.Redirect("Dersler.aspx");
    }
}