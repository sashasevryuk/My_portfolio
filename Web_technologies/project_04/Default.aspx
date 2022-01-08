<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>alcohol C#</title>
<style>
.point img{
width: 30px}
</style>
</head>
<body>
   <div class="header">
    <div class="point"><a href="../default.shtml"><img src="./images/back.png"></a></div>
   </div>

    <form id="form1" runat="server">
    <p>
         <h2><font color='red'>Balmer Peak C#</font></h2>
    </p>
        
        <span class="auto-style1">Weight: </span>&nbsp;<asp:TextBox ID="TextBox1" runat="server">49</asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calc" />
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

