using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : DBAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RpAboutUS.DataSource = GetPageDetails("1", "1");
            RpAboutUS.DataBind();

            RptServices.DataSource = GetServices("1");
            RptServices.DataBind();
        }
    }
}