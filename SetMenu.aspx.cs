using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetMenu : DataAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {

        

        if (!IsPostBack)
        {

         //   ViewState["Guid"] = Session["Guid"].ToString();

            RptStatic.DataSource = GetAllLinksForMenu(Session["GID"].ToString(),"0");
            RptStatic.DataBind();
             


        }


    }
    protected void btnSend_Click(object sender, EventArgs e)
    {

       //     Add_SignUp_User_Content("", "1", string Title, string IsMain, string CountNo);
        DataTable DtSiteInfo = Get_User_SignUp(Session["GID"].ToString());

        Response.Redirect("example/Default.aspx?Site=" + DtSiteInfo.Rows[0]["WebSite_Name"].ToString());

        //int x = New_SignUp_User(TxtName.Text, TxtEmail.Text, txtMobile.Text, txtPassword.Text, txtSite.Text,
        // txtTitle.Text, txtDesc.Text, iname, txtFacebook.Text, txtTwitter.Text, txtGoogle.Text, txtLinkedIn.Text, id);

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        foreach (RepeaterItem category in RptStatic.Items)
        {


            CheckBox cbSelect = (CheckBox)category.FindControl("StaticContentChk");

            string IsMenu = "";

            if (cbSelect.Checked)
                IsMenu = "1";
            else
                IsMenu = "0";

            Update_Menu_SignUp_User_Content(cbSelect.Attributes["ChkID"], IsMenu);
 

        }

        lblMsg.Text = "تم الحفظ بنجاح";
        lblMsg.CssClass = "success";
    }

  
}