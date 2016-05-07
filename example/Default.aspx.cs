using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default : DataAccess
{
    public DataAccess DA = new DataAccess();
    public string   GID;
    protected void Page_Load(object sender, EventArgs e)
    {
        
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
          

            Repeater5.DataSource = GetAllPagesStaticContentHome(Session["GID"].ToString(), "8");
            Repeater5.DataBind();

            RptPages.DataSource = GetAllPagesStaticContentHome(Session["GID"].ToString(), "7");
            RptPages.DataBind();

          


        }
    }

    protected void Repeater5_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DataTable Dt,Dt2 ;
        Repeater Rpt = (Repeater)e.Item.FindControl("Repeater5_1");
        Repeater Rpt2 = (Repeater)e.Item.FindControl("Repeater5_2");

        Dt = GetTopNewsDefault(DataBinder.Eval(e.Item.DataItem, "CatID").ToString(), DataBinder.Eval(e.Item.DataItem, "CountNo").ToString());
        if (Dt.Rows.Count > 0)
        {
            if (DataBinder.Eval(e.Item.DataItem, "StyleType").ToString() == "1")
            {
                Rpt.DataSource = Dt;
                Rpt.DataBind();
                Rpt2.Visible = false;
            }
            else
            {
                Rpt2.DataSource = Dt;
                Rpt2.DataBind();
                Rpt.Visible = false;
            }

        }
        else
        {

            Dt2 = GetTopNews("0", DataBinder.Eval(e.Item.DataItem, "CountNo").ToString());
            if (DataBinder.Eval(e.Item.DataItem, "StyleType").ToString() == "1")
            {
                Rpt.DataSource = Dt2;
                Rpt.DataBind();
                Rpt2.Visible = false;
            }
            else
            {

                Rpt2.DataSource = Dt2;
                Rpt2.DataBind();
                Rpt.Visible = false;
            }
        }
            

    }
    protected void RptPages_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
         DataTable Dt,Dt2;
        Repeater RpAboutUS = (Repeater)e.Item.FindControl("RpAboutUS");
        Dt = DA.GetPages(DataBinder.Eval(e.Item.DataItem, "CatID").ToString(), "1");
        if (Dt.Rows.Count > 0)
        {
            RpAboutUS.DataSource = Dt;
            RpAboutUS.DataBind();
        }
        else
        {
            Dt2 = DA.GetPages("0", "1");
            RpAboutUS.DataSource = Dt2;
            RpAboutUS.DataBind();
        }

    }

}