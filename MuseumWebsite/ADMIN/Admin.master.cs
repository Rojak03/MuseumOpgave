using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_Admin : System.Web.UI.MasterPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            Response.Redirect("../07Login.aspx");
        }
        else
        {
            litLogin.Text = "You are loged in as: <span class='lookatthis'>" + Session["login"] + "</span>";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Remove("login");
        Response.Redirect("../01Default.aspx");
    }
}
