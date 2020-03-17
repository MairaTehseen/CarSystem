<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Basket.aspx.cs" Inherits="Add_to_Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
            <asp:Label ID="lblOrderlineID" runat="server" Text="OrderLineID"></asp:Label>
        &nbsp;:</td>
                <td>
                    <asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOrderID" runat="server" Text="OrderID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProductID" runat="server" Text="ProductID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblQuantity" runat="server" Text="Quantitiy"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="btnOk" runat="server" OnClick="btnSubmit_Click" Text="OK" />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Button1_Click1" />
                </td>
            </tr>
            <tr>
                <td>
        <p>
            &nbsp;</p>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
