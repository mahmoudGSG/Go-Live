using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public DataAccess DA = new DataAccess();
    public string twitter, linkedin, facebook, youtube, googleplus, vblink, roomlink, MobileNo, Email, SiteTitle, GID;
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

        DataAccess.LanguageID = "1";


    }

    public DataTable DtSiteInfo;
    public  string ImageLogo = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!String.IsNullOrEmpty(Request.ServerVariables["HTTP_X_ORIGINAL_URL"]))
        {
            form1.Action = Request.ServerVariables["HTTP_X_ORIGINAL_URL"];
        }

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");


       

        if (!IsPostBack)
        {


            if (Request.QueryString["Site"] != null)
            {
                DataTable DtInfo = DA.Get_User_SignUpByName(Request.QueryString["Site"].ToString());
                if (DtInfo.Rows.Count > 0)
                {
                    GID = DtInfo.Rows[0]["Guid"].ToString();
                    Session["GID"] = GID;
                }
                else
                    Response.Redirect("~/");
            }




            RptMenu.DataSource = DA.GetAllLinksForMenu(Session["GID"].ToString(), "1");
            RptMenu.DataBind();


            DtSiteInfo = DA.Get_User_SignUp(Session["GID"].ToString());
           
            if (DtSiteInfo.Rows[0]["WebSite_Logo"].ToString() != "")
                ImageLogo = DtSiteInfo.Rows[0]["WebSite_Logo"].ToString();
            else
                ImageLogo = "Default.png";

            SiteTitle = DtSiteInfo.Rows[0]["WebSite_Title"].ToString();
            MobileNo = DtSiteInfo.Rows[0]["MobileNo"].ToString();
            Email = DtSiteInfo.Rows[0]["Email"].ToString();

            if (DA.GetCurrentPageName().ToLower().Contains("default"))
                Page.Title += DtSiteInfo.Rows[0]["WebSite_Title"].ToString();
            else
                Page.Title += " | " + DtSiteInfo.Rows[0]["WebSite_Title"].ToString();

            DataTable Dt = DA.GetUserContentByType(Session["GID"].ToString(), "4");
            if (Dt.Rows.Count > 0)
            {
                SliderBox.Visible = true;
                DataTable DtSlide = DA.GetTopMainImage(Session["GID"].ToString());
                Repeater2.DataSource = DtSlide;
                Repeater2.DataBind();
                if (DtSlide.Rows.Count > 0)
                    slide2.Visible = false;
                else
                    slide2.Visible = true;
            }
            else
            {

                SliderBox.Visible = false;
                Repeater2.DataSource = null;
                Repeater2.DataBind();
            }


            DataTable DtEmailList = DA.GetUserContentByType(Session["GID"].ToString(), "3");
            if (DtEmailList.Rows.Count > 0)
            {
                EmailListBox.Visible = true;   
            }
            else
            { 
                EmailListBox.Visible = false; 
            }

            DataTable DtSocialLinks = DA.GetUserContentByType(Session["GID"].ToString(), "1");
            if (DtSocialLinks.Rows.Count > 0)
            {
                SocialLinks1.Visible = true;
            }
            else
            {
                SocialLinks1.Visible = false;
            }


            DataTable DtContact = DA.GetUserContentByType(Session["GID"].ToString(), "2");
            if (DtContact.Rows.Count > 0)
            {
                Contact.Visible = true;
            }
            else
            {
                Contact.Visible = false;
            }


            if (DtContact.Rows.Count > 0 && DtSocialLinks.Rows.Count > 0 && DtEmailList.Rows.Count > 0)
            {
                Ccontact.Visible = true;
            }
            else
            {
                Ccontact.Visible = false;
            }
 
             
            RpMap.DataSource = DA.GetPages("3", "1");
            RpMap.DataBind();

          
        }
    }
}