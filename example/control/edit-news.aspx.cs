using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_edit_news : DataAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Cat"] != null)
        {
            DataTable DtNewsCat = GetNewsCategory(Request.QueryString["Cat"]);
            if (DtNewsCat.Rows.Count > 0)
            {
                Page.Title += " تعديل " + DtNewsCat.Rows[0]["AName"];
                lblTitle.Text = " تعديل " + DtNewsCat.Rows[0]["AName"];
            }
            else
                Response.Redirect("~/Admin");
        }
        else
            Response.Redirect("~/Admin");

        if (!IsPostBack)
        {
            //ddlNewscategory.DataSource = GetAllNewsCategory("1");
            //ddlNewscategory.DataBind();
            //ddlNewscategory.Items.Insert(0, new ListItem("الكــل", "0"));

            BindDate();
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/");
    }
    void BindDate()
    {
        RpNews.DataSource = GetAllNews(Request.QueryString["Cat"], "1");
        RpNews.DataBind();

    }

    protected void ddlNewscategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDate();
    }
}