using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Super_MasterPage : System.Web.UI.MasterPage
{
    DataAccess DA = new DataAccess();


    protected override void OnInit(EventArgs e)
    {


        //if (Request.Cookies["SuperAccountId"] != null && Request.Cookies["SuperAccountId"].Value.ToString() != "")
        //{
        //    DataAccess.UserId = Request.Cookies["SuperAccountId"].Value.ToString();
        //    Name.Text = Request.Cookies["SuperAccountName"].Value.ToString();
 


        //}
        //else
        //    Response.Redirect("~/login.aspx");

        string CurrentPage = Request.Url.ToString().Split('/')[Request.Url.ToString().Split('/').Length - 1].ToLower();
        if (CurrentPage != "default.aspx")
        {
            if (CurrentPage.Contains("?id="))
            {
                CurrentPage = CurrentPage.Replace("?id=" + Request.QueryString["id"], "");
                CurrentPage = CurrentPage.Replace("&cat=", "?cat=");
            }
            else if (CurrentPage.Contains("&id="))
            {
                CurrentPage = CurrentPage.Replace("&id=" + Request.QueryString["id"], "");

            }
         

        }


    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title += "  | لوحة التحكم ";


        if (!IsPostBack)
        {
          
         

            rpPagesRoots.DataSource = DA.GetAllPagesStaticContent(Session["GID"].ToString(), "8");
            rpPagesRoots.DataBind();

            RptStaticPages.DataSource = DA.GetAllPagesStaticContent(Session["GID"].ToString(), "7");
            RptStaticPages.DataBind();
 

        }

    }


     

    protected void lbLogout_Click(object sender, EventArgs e)
    {
        //  Session.Clear();

        Response.Cookies["SuperAccountId"].Expires = DateTime.Now.AddDays(-1);
        Response.Cookies["SuperAccountId"].Expires = DateTime.Now.AddMonths(-1);
        Response.Redirect("~/login.aspx");
    }

    protected void rpPagesRoots_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
}
