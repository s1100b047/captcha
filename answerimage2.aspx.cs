using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class answerimage2 : System.Web.UI.Page
{
    private string Answer1()
    {
        string digital2 = String.Empty; ;
        digital2 = Session["triangle"].ToString();
        Session["digital2"] = digital2;
        return digital2;
    }
    private string Answer2()
    {
        string count2 = String.Empty; ;
        count2 = "1";
        Session["count2"] = count2.ToString();
        return count2;
    }
    private void shapeImage(string color)//將隨機圖形生成圖片
    {
        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(100.0), 100);
        Graphics g = Graphics.FromImage(image);
        Pen pen = new Pen(Color.White, 5);
        SolidBrush sb = new SolidBrush(Color.White);
        string shapenumber2 = String.Empty;
        shapenumber2 = "12";
        g.DrawLine(pen, 30, 30, 30, 70);
        g.DrawLine(pen, 30, 70, 60, 70);
        g.DrawLine(pen, 60, 70, 30, 30);
        Session["shapenumber2"] = shapenumber2.ToString();
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
    private void colorImage(string color)//將亂數數字生成圖片
    {
        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(100.0), 100);
        Graphics g = Graphics.FromImage(image);
        Color rndcolor;
        string colornumber2 = String.Empty;
        Session["colornumber2"] = "22";
        rndcolor = Color.Blue;
        g.Clear(rndcolor);
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
    private void digitalImage(string digital)//將亂數數字生成圖片
    {
        if (digital == null || digital.Trim() == String.Empty)
            return;
        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(digital.Length * 100.0), 100);

        //封裝 GDI+ 點陣圖，此點陣圖由圖形圖像及其屬性的圖元資料組成。Bitmap 是用於處理由圖元資料定義的圖像的物件。
        //Ceiling(Decimal) 返回大於或等於指定的十進位數的最小整數值。
        //Ceiling(Double) 返回大於或等於指定的雙精度浮點數的最小整數值。

        Graphics g = Graphics.FromImage(image);

        //Graphics.FromImage從指定的 Image 創建新的 Graphics。
        //Graphics 類 封裝一個 GDI+ 繪圖圖面。此類不能被繼承。Graphics 類提供將物件繪製到顯示裝置的方法。
        //使用 FromImage 方法從圖像創建 Graphics 物件.

        try
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            g.Clear(Color.White);

            //Clear 清除整個繪圖面並以指定背景色填充。

            for (int i = 0; i < 25; i++)
            {
                int x1 = random.Next(image.Width);//返回大於等於零且小於 MaxValue 的 32 位帶符號整數。
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);

                //DrawLine(Pen, Int32, Int32, Int32, Int32) 繪製一條連接由座標組指定的兩個點的線條。
                //DrawLine(Pen, Single, Single, Single, Single) 繪製一條連接由座標組指定的兩個點的線條。
                //Pen，它確定線條的顏色、寬度和樣式。

            }
            Font font = new System.Drawing.Font("Comic Sans MS", 36, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);

            //LinearGradientBrush 類使用線性漸層封裝 Brush。 無法繼承此類。
            //LinearGradientBrush(Rectangle, Color, Color, Single, Boolean)根據矩形、起始顏色和結束顏色以及方向角度，創建 LinearGradientBrush 類的新實例。
            //一個 Rectangle 結構，它指定線性漸層的界限。

            g.DrawString(digital, font, brush, 19, 12);

            //DrawString(String, Font, Brush, Single, Single) 在指定位置並且用指定的 Brush 和 Font 物件繪製指定的文本字串。
            //Brush定義用於填充圖形形狀（如矩形、橢圓、餅形、多邊形和封閉路徑）的內部的物件。
            //Font定義特定的文本格式，包括字體、字型大小和字形屬性。此類不能被繼承。
            //所繪製文本的左上角的 x 座標。所繪製文本的左上角的 y 座標。

            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));

                //Bitmap .SetPixel 方法獲取此 Bitmap 中指定圖元的顏色。
                //Color .FromArgb 方法基於四個 8 位 ARGB 分量（Alpha、紅色、綠色和藍色）值創建 Color 結構。

            }
            g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

            //DrawRectangle(Pen, Single, Single, Single, Single) 繪製由座標組、寬度和高度指定的矩形。

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

        string question = "";
        if (Session["question"] != null)
        {
            question = Session["question"].ToString();
        }
        if (question == "What is the image background color?")
        {
            this.colorImage(Answer1());
        }
        else if (question == "How many circycle are there?" || question == "How many triangle are there?" || question == "How many square are there?")
        {
            this.digitalImage(Answer1());
        }
        else if (question == "What is the most shape in this image?")
        {
            this.shapeImage(Answer1());
        }
        else if (question == "How many shape are there?")
        {
            this.digitalImage(Answer2());
        }
    }
}