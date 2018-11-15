using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _07Login : System.Web.UI.Page
{
    Adminfac objUser = new Adminfac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnLogin.Focus();

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        dt = objUser.FindUser(txtUsername.Text, txtPassword.Text);

        if (dt.Rows.Count > 0)
        {
            //login Accepted
            Session["login"] = dt.Rows[0]["fldBrugerNavn"] + "(" + dt.Rows[0]["fldPassword"] + ")";
            Session.Timeout = 60;
            Response.Redirect("ADMIN/08AdminDefault.aspx");
        }
        else
        {
            litResult.Text = "Brugernavn og/eller Adgangskode er forkerkt!";
        }
    }
}