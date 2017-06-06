<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="/codecss.css" />
   <!-- <script src="~/myTimer.js"></script>
--></head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <div class="div2">
                <div style="padding: 10px; background-color:white; margin: 10px; border-radius: 10px">
            驗證碼:<asp:Image ID="Image1" runat="server" ImageUrl="~/createcode.aspx" />
            <asp:LinkButton ID="LinkButton1" runat="server">重新產生驗證碼</asp:LinkButton>
            <br />
            請輸入驗證碼:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
                </div>
                    <div style="padding: 10px; background-color:white; margin: 10px; border-radius: 10px">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/informationimage.aspx" />
            <br />
                    </div>
                    <div style="padding: 10px; background-color:white; margin: 10px; border-radius: 10px">
            <asp:Image ID="Image3" runat="server" ImageUrl="~/questionimage.aspx" />
            <br />
                    </div>
                    <div style="padding: 10px; background-color:white; margin: 10px; border-radius: 10px">
                         請選擇答案<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">
                <asp:ListItem Text='<img src="answerimage.aspx" alt="img1" />' Value="1" />
                <asp:ListItem Text='<img src="answerimage2.aspx" alt="img2" />' Value="2" />
                <asp:ListItem Text='<img src="answerimage3.aspx" alt="img3" />' Value="3" />
                <asp:ListItem Text='<img src="answerimage4.aspx" alt="img4" />' Value="4"></asp:ListItem>
            </asp:RadioButtonList>
                    </div>
            <asp:Button ID="Button1"  runat="server" OnClick="Button1_Click" style=" width:60px; height:40px;border-radius: 5px;background-color:#E8FFF5" Text="送出" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            </div>
        </div>
    </form>
</body>
</html>
