using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class admin_Main : DataAccess
{

    DataAccess DA = new DataAccess();
    public string VisitorNo;
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Title += "الصفحـةالرئيسية";

        if (!IsPostBack)
        {
           

        }
 
    }
    

}