<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #FF0000;
            position:absolute;
            top:0px;
                
        }
    </style>
</head>
<body style="background-color: #CCCCCC">
    <form id="form1" runat="server">
        <img src="carlogo.jpg" style="height: 101px; width : 332px; float:right" /><div>
            <h1 class="auto-style1">Add&nbsp; stock</h1>
        </div>
        <asp:Label ID="lblprice" runat="server" style="z-index: 1; left: 15px; top: 176px; position: absolute; width: 30px;" Text="Price"></asp:Label>
        <asp:Label ID="lblmodel" runat="server" style="z-index: 1; left: 16px; position: absolute; top: 149px" Text="Model"></asp:Label>
        <asp:Label ID="lblcolour" runat="server" style="z-index: 1; left: 15px; position: absolute; top: 123px; bottom: 552px;" Text="Colour"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 9px; position: absolute; top: 68px; height: 24px;" Text="Manufacturer"></asp:Label>
        <asp:Label ID="lblyear" runat="server" style="z-index: 1; left: 13px; position: absolute; top: 201px; width: 71px" Text="StockYear"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 103px; top: 172px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 103px; top: 147px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockYear" runat="server" style="z-index: 1; left: 103px; top: 199px; position: absolute"></asp:TextBox>
        <asp:Button  ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 20; left: 12px; top: 236px; position: absolute; height: 26px;" Text="Add" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 236px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
       
        <asp:Label ID="lblquantity" runat="server" style="z-index: 1; left: 13px; top: 94px; position: absolute; bottom: 583px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 104px; top: 90px; position: absolute; right: 1122px; margin-top: 4px;"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 103px; top: 121px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 76px; top: 279px; position: absolute"></asp:Label>
        </p>
        <p style="margin-top: 19px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtManufacturer" runat="server" style="z-index: 1; left: 104px; top: 67px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
