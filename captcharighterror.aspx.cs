using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class captcharighterror : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string answer1 = Session["answer1"].ToString();
        string answer2 = Session["answer2"].ToString();
        int timerr = (int)Session["timerr"];
        Label1.Text = answer1;
        Label2.Text = answer2;
        int b = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        Label3.Text = (b - timerr).ToString() + "秒";
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/main.aspx");
    }
}