<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Google-my</title>
<meta charset="UTF-8" />
    <style>
        .point img{
        width: 30px}
        .primer img{
        width: 1400px}
    </style>
</head>
<body>
   <div class="header">
    <div class="point"><a href="../default.shtml"><img src="./images/back.png"></a></div>
   </div>

    <form id="form1" runat="server">
    <p>
         <h2><font color='blue'>Google-my</font></h2>
            </p>
        
        <span class="auto-style1">&nbsp;</span>&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="97px" />
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        
    </form>
<div class="primer">
        <img src="./images/111.png">
        <img src="./images/11.png">
        <img src="./images/222.png">
        <img src="./images/22.png">
    </div>
</body>
</html>




