using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_RetKontakt : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnConfirm.Focus();
        if (!IsPostBack)
        {
            int ThemaID;

            if (int.TryParse(Request.QueryString["KontaktID"], out ThemaID))
            {



                dt = objThema.GetKontakt();
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["fldKontaktID"].ToString();
                    txtAddress.Text = dt.Rows[0]["fldAdress"].ToString();
                    txtBy.Text = dt.Rows[0]["fldBy"].ToString();
                    txtPost.Text = dt.Rows[0]["fldPostnr"].ToString();
                    txtEmail.Text = dt.Rows[0]["fldEmail"].ToString();
                    txttelephone.Text = dt.Rows[0]["fldtelefone"].ToString();


                }
            }

        }

    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        objThema._KontaktID = Convert.ToInt32(txtID.Text);
        objThema._Address = txtAddress.Text;
        objThema._By = txtBy.Text;
        objThema._Post = txtPost.Text;
        objThema._Email = txtEmail.Text;
        objThema._Telephone = txttelephone.Text;


        int totalThemaEdited = objThema.EditKontakt();

        if (totalThemaEdited > 0)
        {
            litMessage.Text = "<h2>Oplysninger er nu Rettet</h2>";
        }
        else
        {
            litMessage.Text = "<h2>Noget gik galdt!</h2>";
        }
    }
}