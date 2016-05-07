using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sections : DataAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {


        ViewState["Guid"] = "";

        if (!IsPostBack)
        {

         //   ViewState["Guid"] = Session["Guid"].ToString();

            RptStatic.DataSource = Get_StaticContents(Session["Guid"].ToString());
            RptStatic.DataBind();


            BindArticals("8");
            BindPages("7");

        }


    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
   
        Session["GID"] = Session["Guid"];
        Response.Redirect("SetMenu.aspx");
 
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        foreach (RepeaterItem category in RptStatic.Items)
        {


            CheckBox cbSelect = (CheckBox)category.FindControl("StaticContentChk");
            if (cbSelect.Checked)
            {

                Add_SignUp_User_Content(Session["Guid"].ToString(), cbSelect.Attributes["ChkID"], cbSelect.Text, "0", "0", "0", "#Ccontact");

            }
            else
            {
                Delete_SignUp_User_Content(Session["Guid"].ToString(), cbSelect.Attributes["ChkID"]);
            }

        }

        lblMsg.Text = "تم الحفظ بنجاح";
        lblMsg.CssClass = "success";

    }

    void BindPages(string TypeID)
    {

        Repeater1.DataSource = GetAllPagesStaticContent(Session["Guid"].ToString(), TypeID);
        Repeater1.DataBind();
    }

    void BindArticals(string TypeID)
    {

        Repeater2.DataSource = GetAllPagesStaticContent(Session["Guid"].ToString(), TypeID);
        Repeater2.DataBind();
    }


    protected void SaveBtn_Click(object sender, EventArgs e)
    {
        string chk = "";

        if (IsMain.Checked)
            chk = "1";
        else
            chk = "0";

        Add_SignUp_User_Content(Session["Guid"].ToString(), "7", TxtName.Text , chk, "0","0","ViewPage.aspx");
        AddPagesCategory(TxtName.Text, Session["Guid"].ToString());
        TxtName.Text = "";
        IsMain.Checked = false;

        Label1.Text = "تم الحفظ بنجاح";

        BindPages("7");

    }


    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "edit")
        {
            ((Label)e.Item.FindControl("lblName")).Visible = false;
             
            ((TextBox)e.Item.FindControl("txtName")).Visible = true;
             
            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = true;
        }
        if (e.CommandName == "update")
        {
            string IsMain="";
            string Name = ((TextBox)e.Item.FindControl("txtName")).Text;
            CheckBox chk = (CheckBox)e.Item.FindControl("CheckBox1");

            if(chk.Checked)
                IsMain="1";
            else
                IsMain="0";

            UpdatePagesStaticContent(e.CommandArgument.ToString(), Name, IsMain, "0");
            Label1.Text = "تم التحديث بنجاح";

            ((Label)e.Item.FindControl("lblName")).Visible = true;


            ((TextBox)e.Item.FindControl("txtName")).Visible = false;

            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = false;

            BindPages("7");
        }

        if (e.CommandName == "cancel")
        {

            ((Label)e.Item.FindControl("lblName")).Visible = true;
           
            ((TextBox)e.Item.FindControl("txtName")).Visible = false;
            
            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = false;
        }


        if (e.CommandName == "delete")
        {
            string Name = ((TextBox)e.Item.FindControl("txtName")).Text;
          

            DeletePagesStaticContent(e.CommandArgument.ToString());
            DeletePagesCategory(Session["Guid"].ToString(), Name);

            BindPages("7");

        }

    }



    protected void chkMain_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkMain = (CheckBox)sender;
        TextBox txtCount = (TextBox)chkMain.FindControl("txtCount");

        if (chkMain.Checked)
            txtCount.Visible = true;
        else
            txtCount.Visible = false;


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string chk = "";

        if (chkMain.Checked)
            chk = "1";
        else
            chk = "0";

        Add_SignUp_User_Content(Session["Guid"].ToString(), "8", txtArticals.Text, chk, txtCount.Text,DDLStyle.SelectedValue,"Articles.aspx");
        AddNewsCategory(txtArticals.Text, "", Session["Guid"].ToString(), "", "");
        txtArticals.Text = txtCount.Text = "";
        chkMain.Checked = txtCount.Visible = false;

        Label2.Text = "تم الحفظ بنجاح";

        BindArticals("8");

    }



    protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "edit")
        {
            ((Label)e.Item.FindControl("lblName")).Visible = false;

            ((TextBox)e.Item.FindControl("txtName")).Visible = true;

            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = true;
        }
        if (e.CommandName == "update")
        {
            string IsMain = "";
            string Name = ((TextBox)e.Item.FindControl("txtName")).Text;
            string Count = ((TextBox)e.Item.FindControl("txtCount")).Text;
            CheckBox chk = (CheckBox)e.Item.FindControl("CheckBox1");
            DropDownList DDLStyle = (DropDownList)e.Item.FindControl("DDLStyle");

            if (chk.Checked)
                IsMain = "1";
            else
                IsMain = "0";

            UpdatePagesStaticContentArchive(e.CommandArgument.ToString(), Name, IsMain, Count, DDLStyle.SelectedValue);
            Label2.Text = "تم التحديث بنجاح";
            ((Label)e.Item.FindControl("lblName")).Visible = true;


            ((TextBox)e.Item.FindControl("txtName")).Visible = false;

            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = false;

            BindArticals("8");
        }

        if (e.CommandName == "cancel")
        {

            ((Label)e.Item.FindControl("lblName")).Visible = true;

            ((TextBox)e.Item.FindControl("txtName")).Visible = false;

            ((LinkButton)e.Item.FindControl("lnkEdit")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkDelete")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkUpdate")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkCancel")).Visible = false;
        }


        if (e.CommandName == "delete")
        {
            string Name = ((TextBox)e.Item.FindControl("txtName")).Text;
        
            DeletePagesStaticContent(e.CommandArgument.ToString());
            DeleteNewsCategory(Session["Guid"].ToString(), Name);

            BindArticals("8");

        }

    }


    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkMain = (CheckBox)sender;
        TextBox txtCount = (TextBox)chkMain.FindControl("txtCount");

        if (chkMain.Checked)
            txtCount.Visible = true;
        else
            txtCount.Visible = false;
    }
    protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DropDownList DDLStyle = (DropDownList)e.Item.FindControl("DDLStyle");
        DDLStyle.SelectedValue = DataBinder.Eval(e.Item.DataItem, "StyleType").ToString();
    }
}