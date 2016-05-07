using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class admin_add_news : DataAccess
{
    DataAccess DA = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {

        

        if (Request.QueryString["Cat"] != null)
        {
            DataTable DtNewsCat = GetNewsCategory(Request.QueryString["Cat"]);
            if (DtNewsCat.Rows.Count > 0)
            {
                Page.Title += "إضافة وتعديل " + DtNewsCat.Rows[0]["AName"];
                lblTitle.Text = "إضافة وتعديل " + DtNewsCat.Rows[0]["AName"];

               

            }
            else
                Response.Redirect("~/Admin");
        }
        else
            Response.Redirect("~/Admin");


     
         

        if (!Page.IsPostBack)
        {
            TxtDate.Text = DateTime.Now.ToShortDateString();


            ViewState["Image"] = "";
            ViewState["Image2"] = "";

            

            if (Request.QueryString["ID"] != null)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                DataTable DT = GetNews(Request.QueryString["ID"], null);

                if (DT.Rows.Count != 0)
                {
                    TxtTitle.Text = DT.Rows[0]["Title"].ToString();
                   // ddlCategory.SelectedValue = DT.Rows[0]["CategoryID"].ToString();
                    TxtSummary.Text = DT.Rows[0]["Summary"].ToString();
                    Editor.Text = DT.Rows[0]["Details"].ToString();

                    DropDownList1.SelectedValue = DT.Rows[0]["TitleEN"].ToString(); 
                    DropDownList2.SelectedValue = DT.Rows[0]["SummaryEN"].ToString();
                    DropDownList3.SelectedValue = DT.Rows[0]["DetailsEN"].ToString();

                    if (DT.Rows[0]["Active"].ToString() == "True")
                        CheckBox1.Checked = true;

                    
                  //  ddlCategoryBox.Visible = true;

                    TxtTitleEN.Text = DT.Rows[0]["TitleEN"].ToString();
                    TxtSummaryEN.Text = DT.Rows[0]["SummaryEN"].ToString();
                    EditorEN.Text = DT.Rows[0]["DetailsEN"].ToString();

                    TxtPrice.Text = DT.Rows[0]["Link"].ToString();
                    TxtOldPrice.Text = DT.Rows[0]["Link"].ToString();


                    TxtDate.Text = DT.Rows[0]["InsertDate"].ToString();
                    if (DT.Rows[0]["FileName"].ToString() != "")
                    {
                        Img.ImageUrl = "../images/News/" + DT.Rows[0]["FileName"];
                        Img.Visible = true;
                        ViewState["Image"] = DT.Rows[0]["FileName"];
                    }
                    else
                        Img.Visible = false;


                    if (DT.Rows[0]["pdffile"].ToString() != "")
                    {
                        
                        ViewState["Image2"] = DT.Rows[0]["pdffile"];
                    }

                }
                else
                {
                    Response.Redirect("~/Admin/");
                }

            }
            else { }
        }


    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {

        string iname = "";
        iname = iname.Split('/')[iname.Split('/').Length - 1];

        if (FUImg.FileName != "")
        {
            string name = FUImg.FileName;
            string type = name.Split('.')[name.Split('.').Length - 1].ToLower();
            if (type != "jpg" && type != "jpeg" && type != "png" && type != "gif")
            {
                lblMsg.Text = "الرجاء اختيار نوع امتداد صحيح للصور مثل jpg,gif,png";
                return;
            }
            iname = Guid.NewGuid() + "." + type;
            System.IO.File.Delete((MapPath("../images/News\\") + iname));
            iname = iname.ToString().Remove(iname.ToString().IndexOf(".")) + "." + type;
            FUImg.SaveAs(MapPath("../images/News\\") + iname);

        }
        int Check;
        string Summary = TxtSummary.Text;
        //if (Request.QueryString["Cat"] == "5" || Request.QueryString["Cat"] == "6")
        //    Summary = TxtPrice.Text;

        string sshow = "";

        if (CheckBox1.Checked)
            sshow = "1";
        else
            sshow = "0";


        Check = AddNews(Request.QueryString["Cat"], TxtTitle.Text, TxtTitleEN.Text, Editor.Text, EditorEN.Text, Summary, TxtSummaryEN.Text, iname, "1", "1", TxtDate.Text, sshow);
        if (Check > 0)
        {
            lblMsg.Text = "تمت الاضافة بنجاح";


            TxtPrice.Text = TxtOldPrice.Text = "";
            TxtTitle.Text = TxtSummary.Text = Editor.Text = TxtDate.Text = TxtTitleEN.Text = TxtSummaryEN.Text = EditorEN.Text = "";
        }
        else
            lblMsg.Text = "خطأ في عملية الإضافة";
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string iname = "";
        iname = iname.Split('/')[iname.Split('/').Length - 1];

        if (FUImg.FileName != "")
        {
            string name = FUImg.FileName;
            string type = name.Split('.')[name.Split('.').Length - 1].ToLower();
            if (type != "jpg" && type != "jpeg" && type != "png" && type != "gif")
            {
                lblMsg.Text = "الرجاء اختيار نوع امتداد صحيح للصور مثل jpg,gif,png";
                return;
            }
            iname = Guid.NewGuid() + "." + type;
            if (System.IO.File.Exists((MapPath("../images/News\\") + ViewState["Image"].ToString())))
                System.IO.File.Delete((MapPath("../images/News\\") + ViewState["Image"].ToString()));
            iname = iname.ToString().Remove(iname.ToString().IndexOf(".")) + "." + type;
            FUImg.SaveAs(MapPath("../images/News\\") + iname);

        }
        else
        {

            iname = ViewState["Image"].ToString();
        }


        string sshow = "";

        if (CheckBox1.Checked)
            sshow = "1";
        else
            sshow = "0";


        string Summary = TxtSummary.Text;
        //if (Request.QueryString["Cat"] == "5" || Request.QueryString["Cat"] == "6")
        //    Summary = TxtPrice.Text;
        UpdateNews(Request.QueryString["ID"], TxtTitle.Text, TxtTitleEN.Text, Editor.Text, EditorEN.Text, Summary, TxtSummaryEN.Text, iname, "1", Request.QueryString["Cat"], TxtDate.Text, sshow);
        lblMsg.Text = "تم التحديث بنجاح";

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/");
    }



}