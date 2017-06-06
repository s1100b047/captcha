using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string answer1 = "";
        string checkCode = Session["CheckCode"].ToString();
        if (checkCode.ToLower() == TextBox1.Text || checkCode.ToUpper() == TextBox1.Text)
        {
            answer1 = "驗證碼輸入正確";
        }
        else
        {
            answer1 = "驗證碼輸入不正確";
        }
        Session["answer1"] = answer1.ToString();
        Response.Redirect("~/captcharighterror.aspx");
    }
    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //information
        string randomcolor = Session["randomcolor"].ToString();//information顏色rnd
        string mostshape = Session["mostshape"].ToString();
        string shape = Session["shape"].ToString();//幾種圖型
        string circycle = Session["circyle"].ToString();
        string triangle = Session["triangle"].ToString();
        string square = Session["square"].ToString();
        //question
        string question = "";
        if (Session["question"] != null)
        {
            question = Session["question"].ToString();
        }

        //answer
        string digital = "";//circle
        if (Session["digital"] != null)
        {
            digital = Session["digital"].ToString();//圓形三角形正方型數量的亂數
        }
        string digital2 = "";//triangle
        if (Session["digital2"] != null)
        {
            digital2 = Session["digital2"].ToString();//圓形三角形正方型數量的亂數
        }
        string digital3 = "";//square
        if (Session["digital3"] != null)
        {
            digital3 = Session["digital3"].ToString();//圓形三角形正方型數量的亂數
        }
        string digital4 = "";//0
        if (Session["digital4"] != null)
        {
            digital4 = Session["digital4"].ToString();//圓形三角形正方型數量的亂數
        }
        string count = "";//幾種圖型0
        if (Session["count"] != null)
        {
            count = Session["count"].ToString();//圓形三角形正方型數量的亂數
        }
        string count2 = "";//幾種圖型1
        if (Session["count2"] != null)
        {
            count2 = Session["count2"].ToString();//圓形三角形正方型數量的亂數
        }
        string count3 = "";//幾種圖型2
        if (Session["count3"] != null)
        {
            count3 = Session["count3"].ToString();//圓形三角形正方型數量的亂數
        }
        string count4 = "";//幾種圖型3
        if (Session["count4"] != null)
        {
            count4 = Session["count4"].ToString();//圓形三角形正方型數量的亂數
        }
        string shapenumber = "";
        if (Session["shapenumber"] != null)
        {
            shapenumber = Session["shapenumber"].ToString();//最多的圖型圓形
        }
        string shapenumber2 = "";
        if (Session["shapenumber2"] != null)
        {
            shapenumber2 = Session["shapenumber2"].ToString();//最多的圖型三角形
        }
        string shapenumber3 = "";
        if (Session["shapenumber3"] != null)
        {
            shapenumber3 = Session["shapenumber3"].ToString();//最多的圖型正方型
        }
        string shapenumber4 = "";
        if (Session["shapenumber4"] != null)
        {
            shapenumber4 = Session["shapenumber4"].ToString();//最多的圖型都有
        }
        string colornumber = "";
        if (Session["colornumber"] != null)
        {
            colornumber = Session["colornumber"].ToString();//red
        }
        string colornumber2 = "";
        if (Session["colornumber2"] != null)
        {
            colornumber2 = Session["colornumber2"].ToString();//blue
        }
        string colornumber3 = "";
        if (Session["colornumber3"] != null)
        {
            colornumber3 = Session["colornumber3"].ToString();//gray
        }
        string colornumber4 = "";
        if (Session["colornumber4"] != null)
        {
            colornumber4 = Session["colornumber4"].ToString();//green
        }
        string select = "";
        select = RadioButtonList1.SelectedValue;
        string select2 = "";
        if (question == "What is the image background color?" && (select == "1"))//判斷顏色
        {
            select2 = "21";
        }
        else if (question == "What is the image background color?" && (select == "2"))
        {
            select2 = "22";
        }
        else if (question == "What is the image background color?" && (select == "3"))
        {
            select2 = "23";
        }
        else if (question == "What is the image background color?" && (select == "4"))
        {
            select2 = "24";
        }
        if (question == "How many circycle are there?" && (select == "1"))//判斷圓形
        {
            select2 = circycle;
        }
        else if (question == "How many circycle are there?" && (select == "2"))
        {
            select2 = triangle;
        }
        else if (question == "How many circycle are there?" && (select == "3"))
        {
            select2 = square;
        }
        else if (question == "How many circycle are there?" && (select == "4"))
        {
            select2 = "0";
        }
        if (question == "How many triangle are there?" && (select == "1"))//判斷三角形
        {
            select2 = circycle;
        }
        else if (question == "How many triangle are there?" && (select == "2"))
        {
            select2 = triangle;
        }
        else if (question == "How many triangle are there?" && (select == "3"))
        {
            select2 = square;
        }
        else if (question == "How many triangle are there?" && (select == "4"))
        {
            select2 = "0";
        }
        if (question == "How many square are there?" && (select == "1"))//判斷正方形
        {
            select2 = circycle;
        }
        else if (question == "How many square are there?" && (select == "2"))
        {
            select2 = triangle;
        }
        else if (question == "How many square are there?" && (select == "3"))
        {
            select2 = square;
        }
        else if (question == "How many square are there?" && (select == "4"))
        {
            select2 = "0";
        }
        if (question == "What is the most shape in this image?" && (select == "1"))//判斷最多圖形
        {
            select2 = "11";
        }
        else if (question == "What is the most shape in this image?" && (select == "2"))
        {
            select2 = "12";
        }
        else if (question == "What is the most shape in this image?" && (select == "3"))
        {
            select2 = "13";
        }
        else if (question == "What is the most shape in this image?" && (select == "4"))
        {
            select2 = "14";
        }
        if (question == "How many shape are there?" && (select == "1"))//判斷幾種圖形
        {
            select2 = "0";
        }
        else if (question == "How many shape are there?" && (select == "2"))
        {
            select2 = "1";
        }
        else if (question == "How many shape are there?" && (select == "3"))
        {
            select2 = "2";
        }
        else if (question == "How many shape are there?" && (select == "4"))
        {
            select2 = "3";
        }
        string answer2 = "";//取得驗證碼選擇是否正確
        if (question == "What is the image background color?" && (select2 == randomcolor))
        {
            answer2 = "答案選擇正確";
        }
        else if (question == "How many circycle are there?" && (select2 == circycle))
        {
            answer2 = "答案選擇正確";
        }
        else if (question == "How many triangle are there?" && (select2 == triangle))
        {
            answer2 = "答案選擇正確";
        }
        else if (question == "How many square are there?" && (select2 == square))
        {
            answer2 = "答案選擇正確";
        }
        else if (question == "What is the most shape in this image?" && (select2 == mostshape))
        {
            answer2 = "答案選擇正確";
        }
        else if (question == "How many shape are there?" && (select2 == shape))
        {
            answer2 = "答案選擇正確";
        }
        else
        {
            answer2 = "答案選擇不正確";
        }
        Session["answer2"] = answer2.ToString();
    }
}