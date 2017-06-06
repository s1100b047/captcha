using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class informationimage : System.Web.UI.Page
{
    private string Answer1()
    {
        Session["timerr"] = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        string digital;
        Random random = new Random(Guid.NewGuid().GetHashCode());//亂數種子
        int i = random.Next(0, 10);//回傳0-9的亂數
        digital = i.ToString();
        return digital;
    }
    private void shapeImage(string color)//將隨機圖形生成圖片
    {
        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(200.0), 200);
        Graphics g = Graphics.FromImage(image);
        Color rndcolor;//隨機背景顏色
        Random rnd2 = new Random(Guid.NewGuid().GetHashCode());
        string randomcolor = String.Empty;
        int j = rnd2.Next(21, 25);
        if (j == 21)
        {
            Session["randomcolor"] = "21";
            rndcolor = Color.Red;
        }
        else if (j == 22)
        {
            Session["randomcolor"] = "22";
            rndcolor = Color.Blue;
        }
        else if (j == 23)
        {
            Session["randomcolor"] = "23";
            rndcolor = Color.Gray;
        }
        else
        {
            Session["randomcolor"] = "24";
            rndcolor = Color.Green;
        }
        g.Clear(rndcolor);
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        Pen pen = new Pen(Color.Black, 5);
        SolidBrush sb = new SolidBrush(Color.Black);
        int number = rnd.Next(11, 15);//隨機9個圖型
        int number2 = rnd.Next(11, 15);//隨機圖型
        int number3 = rnd.Next(11, 15);//隨機圖型顏色
        int number4 = rnd.Next(11, 15);//隨機背景顏色
        int number5 = rnd.Next(11, 15);
        int number6 = rnd.Next(11, 15);
        int number7 = rnd.Next(11, 15);
        int number8 = rnd.Next(11, 15);
        int number9 = rnd.Next(11, 15);
        int i, circyle, triangle, square, shape, mostshape;
        circyle = 0; triangle = 0; square = 0; shape = 0; mostshape = 0;
        for (i = 11; i <= 19; i++)//各個位置隨機圖形
        {
            if (i == 11)
            {
                if (number == 11)//圓形
                {
                    g.FillEllipse(sb, 10, 10, 25, 25);
                    circyle++;
                }
                else if (number == 12)//三角形
                {
                    g.DrawLine(pen, 10, 10, 10, 50);
                    g.DrawLine(pen, 10, 50, 40, 50);
                    g.DrawLine(pen, 40, 50, 10, 10);
                    triangle++;
                }
                else if (number == 13)//正方型
                {
                    g.DrawRectangle(pen, 10, 10, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 12)
            {
                if (number2 == 11)//圓形
                {
                    g.FillEllipse(sb, 70, 10, 25, 25);
                    circyle++;
                }
                else if (number2 == 12)//三角形
                {
                    g.DrawLine(pen, 70, 10, 70, 50);
                    g.DrawLine(pen, 70, 50, 100, 50);
                    g.DrawLine(pen, 100, 50, 70, 10);
                    triangle++;
                }
                else if (number2 == 13)//正方型
                {
                    g.DrawRectangle(pen, 70, 10, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 13)
            {
                if (number3 == 11)//圓形
                {
                    g.FillEllipse(sb, 130, 10, 25, 25);
                    circyle++;
                }
                else if (number3 == 12)//三角形
                {
                    g.DrawLine(pen, 130, 10, 130, 50);
                    g.DrawLine(pen, 130, 50, 160, 50);
                    g.DrawLine(pen, 160, 50, 130, 10);
                    triangle++;
                }
                else if (number3 == 13)//正方型
                {
                    g.DrawRectangle(pen, 130, 10, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 14)
            {
                if (number4 == 11)//圓形
                {
                    g.FillEllipse(sb, 10, 70, 25, 25);
                    circyle++;
                }
                else if (number4 == 12)//三角形
                {
                    g.DrawLine(pen, 10, 70, 10, 110);
                    g.DrawLine(pen, 10, 110, 40, 110);
                    g.DrawLine(pen, 40, 110, 10, 70);
                    triangle++;
                }
                else if (number4 == 13)//正方型
                {
                    g.DrawRectangle(pen, 10, 70, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 15)
            {
                if (number5 == 11)//圓形
                {
                    g.FillEllipse(sb, 10, 130, 25, 25);
                    circyle++;
                }
                else if (number5 == 12)//三角形
                {
                    g.DrawLine(pen, 10, 130, 10, 170);
                    g.DrawLine(pen, 10, 170, 40, 170);
                    g.DrawLine(pen, 40, 170, 10, 130);
                    triangle++;
                }
                else if (number5 == 13)//正方型
                {
                    g.DrawRectangle(pen, 10, 130, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 16)
            {
                if (number6 == 11)//圓形
                {
                    g.FillEllipse(sb, 70, 70, 25, 25);
                    circyle++;
                }
                else if (number6 == 12)//三角形
                {
                    g.DrawLine(pen, 70, 70, 70, 110);
                    g.DrawLine(pen, 70, 110, 100, 110);
                    g.DrawLine(pen, 100, 110, 70, 70);
                    triangle++;
                }
                else if (number6 == 13)//正方型
                {
                    g.DrawRectangle(pen, 70, 70, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 17)
            {
                if (number7 == 11)//圓形
                {
                    g.FillEllipse(sb, 70, 130, 25, 25);
                    circyle++;
                }
                else if (number7 == 12)//三角形
                {
                    g.DrawLine(pen, 70, 130, 70, 170);
                    g.DrawLine(pen, 70, 170, 100, 170);
                    g.DrawLine(pen, 100, 170, 70, 130);
                    triangle++;
                }
                else if (number7 == 13)//正方型
                {
                    g.DrawRectangle(pen, 70, 130, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 18)
            {
                if (number8 == 11)//圓形
                {
                    g.FillEllipse(sb, 130, 70, 25, 25);
                    circyle++;
                }
                else if (number8 == 12)//三角形
                {
                    g.DrawLine(pen, 130, 70, 130, 110);
                    g.DrawLine(pen, 130, 110, 160, 110);
                    g.DrawLine(pen, 160, 110, 130, 70);
                    triangle++;
                }
                else if (number8 == 13)//正方型
                {
                    g.DrawRectangle(pen, 130, 70, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (i == 19)
            {
                if (number9 == 11)//圓形
                {
                    g.FillEllipse(sb, 130, 130, 25, 25);
                    circyle++;
                }
                else if (number9 == 12)//三角形
                {
                    g.DrawLine(pen, 130, 130, 130, 170);
                    g.DrawLine(pen, 130, 170, 160, 170);
                    g.DrawLine(pen, 160, 170, 130, 130);
                    triangle++;
                }
                else if (number9 == 13)//正方型
                {
                    g.DrawRectangle(pen, 130, 130, 15, 15);
                    Brush blueBrush = new SolidBrush(Color.Blue);
                    square++;
                }
                else
                {
                }
            }
            if (circyle != 0)
            {
                shape++;
            }
            if (triangle != 0)
            {
                shape++;
            }
            if (square != 0)
            {
                shape++;
            }
            if (circyle > triangle && circyle > square)
            {
                mostshape = 11;
            }
            if (triangle > circyle && triangle > square)
            {
                mostshape = 12;
            }
            if (square > triangle && square > triangle)
            {
                mostshape = 13;
            }
            if (square == triangle || square == triangle)
            {
                mostshape = 14;
            }
            Session["mostshape"] = mostshape.ToString();
            Session["shape"] = shape.ToString();
            Session["circyle"] = circyle.ToString();
            Session["triangle"] = triangle.ToString();
            Session["square"] = square.ToString();
        }

        //Graphics.FromImage從指定的 Image 創建新的 Graphics。
        //Graphics 類 封裝一個 GDI+ 繪圖圖面。此類不能被繼承。Graphics 類提供將物件繪製到顯示裝置的方法。
        //使用 FromImage 方法從圖像創建 Graphics 物件.
        try
        {
            //DrawString(String, Font, Brush, Single, Single) 在指定位置並且用指定的 Brush 和 Font 物件繪製指定的文本字串。
            //Brush定義用於填充圖形形狀（如矩形、橢圓、餅形、多邊形和封閉路徑）的內部的物件。
            //Font定義特定的文本格式，包括字體、字型大小和字形屬性。此類不能被繼承。
            //所繪製文本的左上角的 x 座標。所繪製文本的左上角的 y 座標。
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            //MemoryStream 類創建其支援存儲區為記憶體的流。
            //MemoryStream 類創建一個流，該流使用記憶體作為後備存儲而不是磁片或網路連接。
            //MemoryStream 封裝作為無符號位元組陣列存儲的資料，該陣列在創建 MemoryStream 物件時進行初始化，或可創建空陣列。
            //可在記憶體中直接存取這些封裝的資料。記憶體流可降低應用程式中對臨時緩衝區和暫存檔案的需要。

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

            //Bitmap .Save 方法將此圖像以指定的格式保存到指定的流中。
            //Image .Save 方法 (Stream, ImageFormat)將此圖像以指定的格式保存到指定的流中。

            Response.ClearContent();
            //HttpResponse .ClearContent 方法清除緩衝區流中的所有內容輸出。
            Response.ContentType = "image/Gif";
            //HttpResponse .ContentType 屬性獲取或設置輸出流的 HTTP MIME 類型。
            Response.BinaryWrite(ms.ToArray());
            //HttpResponse .BinaryWrite 方法將一個二進位字串寫入 HTTP 輸出流。
        }
        finally
        {
            g.Dispose();//Dispose 釋放由 Graphics 使用的所有資源。
            image.Dispose();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.shapeImage(Answer1());
    }
}