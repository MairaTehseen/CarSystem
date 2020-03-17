<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 48px; top: 90px; position: absolute; width: 46px" Text="YES" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 166px; top: 90px; position: absolute; width: 50px" Text="NO" OnClick="btnNo_Click" />
        <asp:Label ID="lblErrormessage" runat="server" style="color: #FFFFFF; background-color: #000000" Text="Are you sure you want to delete this item?"></asp:Label>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 170px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
