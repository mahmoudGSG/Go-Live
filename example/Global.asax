﻿<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
     
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

        //HttpContext.Current.Response.Cookies[""].Value = "0";
    
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

        if (Application["VisitorCounter"] == null)
            Application["VisitorCounter"] = 1;
        else
            Application["VisitorCounter"] = Convert.ToInt32(Application["VisitorCounter"]) + 1;
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
        if (Application["VisitorCounter"] != null && Convert.ToInt32(Application["VisitorCounter"]) > 0)
            Application["VisitorCounter"] = Convert.ToInt32(Application["VisitorCounter"]) - 1;
       
    }
       
</script>
