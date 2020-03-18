<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomerMessage" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure want to delete this customer record?"></asp:Label>
        <asp:Button ID="btnYesDeleteCustomer" runat="server" OnClick="btnYesDeleteCustomer_Click" style="z-index: 1; left: 13px; top: 64px; position: absolute; width: 55px" Text="Yes" />
        <asp:Button ID="btnNoDeleteCustomer" runat="server" style="z-index: 1; left: 79px; top: 64px; position: absolute; width: 62px" Text="No" OnClick="btnNoDeleteCustomer_Click" />
    </form>
</body>
</html>
