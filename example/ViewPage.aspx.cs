using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewPage : DataAccess
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Cat"] != null)
        {
            DataTable DtCat = GetPagesCategory(Request.QueryString["Cat"]);
            if (DtCat.Rows.Count > 0)
            {
                Page.Title += DtCat.Rows[0]["AName"];
                lblTitle.InnerHtml = DtCat.Rows[0]["AName"].ToString();
 
                 
                DataTable Dt = GetPages(Request.QueryString["Cat"], DataAccess.LanguageID);
                if (Dt.Rows.Count > 0)
                {
                    RpAboutUS.DataSource = Dt;
                    RpAboutUS.DataBind();

                  
                }
                else
                {
                    lblNoResults.Visible = true;
                }
            }
            else
                Response.Redirect("~/example");
        }
        else
            Response.Redirect("~/example");
    }
}