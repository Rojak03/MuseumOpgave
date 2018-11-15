using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_14SletThemaConfirm : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        int themaid;

        if (int.TryParse(Request.QueryString["themaID"], out themaid))
        {
            objThema.DeleteThema(themaid);

            litMessage.Text = "Thema Sletet";
        }
        else
        {
            litMessage.Text = "Noget Gik Gladet";
        }
    }
}