<%@ Page Language="C#" AutoEventWireup="true" CodeFile="captcharighterror.aspx.cs" Inherits="captcharighterror" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="/codecss.css" />
   <!-- <script src="~/myTimer.js"></script>-->
</head>
<body >
    <form id="form1" runat="server">
        <div class="div1">
            <div class="div2">
              <!--  <script>
                    timedCount();
                    var sss = myTimer;
                    document.getElementById("Label3").value = gettime();
                </script> -->
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">回到上一頁</asp:LinkButton>
                
            </div>
        </div>
    </form>
</body>
</html>

