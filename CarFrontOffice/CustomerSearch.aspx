<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSearch.aspx.cs" Inherits="CustomerSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 19px; width: 666px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstbxCustomers" runat="server" style="z-index: 1; left: 8px; top: 97px; position: absolute; height: 169px; width: 527px"></asp:ListBox>
        <p>
            <asp:TextBox ID="txtbxSearchCustomerLast" runat="server" style="z-index: 1; left: 12px; top: 315px; position: absolute; width: 143px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 289px; position: absolute; width: 148px" Text="Search by last name"></asp:Label>
        <asp:Button ID="btnSearchCustomer" runat="server" OnClick="btnSearchCustomer_Click" style="z-index: 1; left: 12px; top: 364px; position: absolute; width: 114px" Text="Search" />
        <p>
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 135px; top: 364px; position: absolute; width: 139px" Text="Display All" />
        </p>
        <p>
            <asp:Button ID="btnAddCustomer" runat="server" OnClick="btnAddCustomer_Click" style="z-index: 1; left: 13px; top: 419px; position: absolute; width: 74px" Text="Add" />
        </p>
        <asp:Button ID="btnUpdateCustomer" runat="server" OnClick="btnUpdateCustomer_Click" style="z-index: 1; left: 95px; top: 419px; position: absolute; width: 71px" Text="Update" />
        <asp:Button ID="btnDeleteCustomer" runat="server" OnClick="btnDeleteCustomer_Click" style="z-index: 1; left: 176px; top: 418px; position: absolute; width: 83px" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 470px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
