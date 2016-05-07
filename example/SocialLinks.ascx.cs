using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SocialLinks : System.Web.UI.UserControl
{
    DataAccess DA = new DataAccess();
    public string twitter, linkedin, facebook, youtube, googleplus;
    protected void Page_Load(object sender, EventArgs e)
    {

        DataTable DtPositionLink = DA.Get_User_SignUp(Session["GID"].ToString());
        twitter = DtPositionLink.Rows[0]["Twitter_Url"].ToString();
        linkedin = DtPositionLink.Rows[0]["LinkedIN_Url"].ToString();
        facebook = DtPositionLink.Rows[0]["Facebook_Url"].ToString();
        googleplus = DtPositionLink.Rows[0]["Google_Url"].ToString();

    }
}