<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deletestockpage.aspx.cs" Inherits="Deletestockpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            color: #CC0000;
        }
    </style>
</head>
<body style="background-color: #CCCCCC">
     <form id="form1" runat="server">
         <img src="carlogo.jpg" style="height: 101px; width : 332px; float:right" /><div>
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 184px; position: absolute"></asp:Label>
            <h1 class="auto-style2">Delete stock</h1>
         </div>
        <asp:Button ID="btnyes" runat="server" style="z-index: 1; left: 14px; top: 130px; position: absolute" Text="Yes" OnClick="btnyes_Click" />
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 75px; top: 130px; position: absolute" Text="No" />
    </form>
</body>
</html>
