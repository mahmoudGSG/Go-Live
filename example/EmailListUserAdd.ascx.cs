using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EmailListUserAdd : System.Web.UI.UserControl
{
    DataAccess DA = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEmailAdd_Click(object sender, EventArgs e)
    {
        int x = DA.AddEmailList("", TxtEmail.Text, "", "1", Session["GID"].ToString(), "");
        if (x == -2)
        {
            lblMsg.Text = "الموبايل  مسجل لدينا";
            lblMsg.CssClass = "error";
        }
        else
        {
            lblMsg.Text = "تم التسجيل بنجاح";
            TxtEmail.Text = "";
            lblMsg.CssClass = "success";
        }
    }

}