using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SocialLinks : System.Web.UI.UserControl
{
    DBAccess DA = new DBAccess();
    public string twitter, linkedin, facebook, youtube, googleplus;

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable DtPositionLink = DA.GetContacts("1", "1");

        twitter = DtPositionLink.Rows[0]["Twt"].ToString();
        linkedin = DtPositionLink.Rows[0]["Lin"].ToString();
        facebook = DtPositionLink.Rows[0]["FB"].ToString();
        youtube = DtPositionLink.Rows[0]["Youtube"].ToString();
        googleplus = DtPositionLink.Rows[0]["Gplus"].ToString();

    }
}