using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageSite : System.Web.UI.MasterPage
{
    DBAccess DB = new DBAccess();
    protected override void OnInit(EventArgs e)
    {
        if (Request.Browser.Browser.ToLower() == "ie" && Convert.ToDouble(Request.Browser.Version.ToString()) < 8.0)
            Response.Redirect("~/BrowserUpdate.aspx?Browser=" + Request.Browser.Browser.ToLower());

        if (Request.Browser.Browser.ToLower() == "firefox" && Convert.ToDouble(Request.Browser.Version.ToString()) < 6.0)
            Response.Redirect("~/BrowserUpdate.aspx?Browser=" + Request.Browser.Browser.ToLower());

        if (Request.Browser.Browser.ToLower() == "safari" && Convert.ToDouble(Request.Browser.Version.ToString()) < 4.0)
            Response.Redirect("~/BrowserUpdate.aspx?Browser=" + Request.Browser.Browser.ToLower());

        if (Request.Browser.Browser.ToLower() == "opera" && Convert.ToDouble(Request.Browser.Version.ToString()) < 8.0)
            Response.Redirect("~/BrowserUpdate.aspx?Browser=" + Request.Browser.Browser.ToLower());

        if (Request.Browser.Browser.ToLower() == "chrome" && Convert.ToDouble(Request.Browser.Version.ToString()) < 7.0)
            Response.Redirect("~/BrowserUpdate.aspx?Browser=" + Request.Browser.Browser.ToLower());
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (DB.GetCurrentPageName().ToLower().Contains("default"))
            Page.Title += "Go Live";
        else
            Page.Title += " | Go Live";

        if (!String.IsNullOrEmpty(Request.ServerVariables["HTTP_X_ORIGINAL_URL"]))
        {
            form1.Action = Request.ServerVariables["HTTP_X_ORIGINAL_URL"];
        }

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

        if (!IsPostBack)
        {
            Repeater2.DataSource = DB.GetTopMainImage();
            Repeater2.DataBind();

            // GetSiteContacts
            Repeater1.DataSource = DB.GetContacts("1", "1");
            Repeater1.DataBind();

            // GetSiteMap
            RpMap.DataSource = DB.GetContacts("2", "1");
            RpMap.DataBind();
        }

    }
}
