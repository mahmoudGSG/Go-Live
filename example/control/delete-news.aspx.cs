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
                Page.Title += " حذف " + DtNewsCat.Rows[0]["AName"];
                lblTitle.Text = " حذف " + DtNewsCat.Rows[0]["AName"];
            }
            else
                Response.Redirect("~/Admin");
        }
        else
            Response.Redirect("~/Admin");

        if (!IsPostBack)
        {
            ddlNewscategory.DataSource = GetAllNewsCategory("1");
            ddlNewscategory.DataBind();
            ddlNewscategory.Items.Insert(0, new ListItem("الكــل", "0"));
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


    //protected void RpNews_ItemCommand(object source, RepeaterCommandEventArgs e)
    //{

    //    if (e.CommandName == "delete")
    //    {
    //        try
    //        {
    //            DeleteNews(e.CommandArgument.ToString());
    //            lblMsg.Text = "تم الحذف  بنجاح";
    //            BindDate();
    //        }
    //        catch (Exception ex)
    //        {
    //            lblMsg.Text = ex.Message;
    //        }
    //        finally
    //        {

    //        }
    //    }
    //}





    protected void cpRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
        LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
        LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
        LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
        Label lblName = (Label)e.Item.FindControl("lblName");
        Label lblrptID = (Label)e.Item.FindControl("lblID");
        TextBox txtName = (TextBox)e.Item.FindControl("txtName");
        DropDownList ddlType = (DropDownList)e.Item.FindControl("ddlType");
        CheckBox chkDelete = (CheckBox)e.Item.FindControl("chkDelete");

        if (e.CommandName == "edit")
        {
            lnkCancel.Visible = true;
            lnkUpdate.Visible = true;
            lnkEdit.Visible = false;
            txtName.Visible = true;
            lblName.Visible = false;

        }
        if (e.CommandName == "cancel")
        {

        }
        if (e.CommandName == "update")
        {

        }
        if (e.CommandName == "delete")
        {

            DeleteNews(e.CommandArgument.ToString());



            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
            }

            BindDate();

        }

    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {


        foreach (RepeaterItem Item in RpNews.Items)
        {


            CheckBox chkDelete = (CheckBox)Item.FindControl("chkDelete");
            Label lblrptID = (Label)Item.FindControl("lblID");
            Label lblName = (Label)Item.FindControl("lblName");
            TextBox txtName = (TextBox)Item.FindControl("txtName");


            if (chkDelete.Checked)
            {


                DeleteNews(lblrptID.Text);


            }
        }

        BindDate();

        chkSelectAll.Checked = false;

    }


    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkSelectAll.Checked == true)
        {
            foreach (RepeaterItem Item in RpNews.Items)
            {
                CheckBox chkSel = (CheckBox)Item.FindControl("chkDelete");
                chkSel.Checked = true;

            }
        }
        else
        {
            foreach (RepeaterItem Item in RpNews.Items)
            {
                CheckBox chkSel = (CheckBox)Item.FindControl("chkDelete");
                chkSel.Checked = false;

            }
        }
    }







}