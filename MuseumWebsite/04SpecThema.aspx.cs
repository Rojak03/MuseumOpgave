using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04SpecThema : System.Web.UI.Page
{
    MuseumFac objthema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        int themaID;

        if (int.TryParse(Request.QueryString["ThemaID"], out themaID))
        {
            dt = objthema.GetThemaFromID(themaID);

            if (dt.Rows.Count > 0)
            {
                litShowThema.Text += "<div id=themabox><h2>";
                litShowThema.Text += dt.Rows[0]["fldTitle"].ToString() + "</h2></br><p>";
                litShowThema.Text += dt.Rows[0]["fldDescription"].ToString()+"</p></div>";
            }
            else
            {
                Response.Redirect("01Default.aspx");
            }

        }
    }
}