<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteAccount.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Are you shre you want to delete this address?"></asp:Label>
        <p>
            <asp:Button ID="ButtonYes" runat="server" OnClick="ButtonYes_Click" Text="Yes" />
            <asp:Button ID="ButtonNo" runat="server" OnClick="ButtonNo_Click" Text="No" />
        </p>
    </form>
</body>
</html>
