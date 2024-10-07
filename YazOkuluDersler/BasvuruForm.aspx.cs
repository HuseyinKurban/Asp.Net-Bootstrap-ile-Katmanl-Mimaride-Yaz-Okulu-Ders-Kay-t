using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class BasvuruForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityBasvuruForm> BasvuruList = BLLBasvuruForm.BllBasvuruListele();
        Repeater1.DataSource = BasvuruList;
        Repeater1.DataBind();
    }
}