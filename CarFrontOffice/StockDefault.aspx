<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDefault.aspx.cs" Inherits="_Default" %>

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
        <h1 style="width: 216px; font-size: x-large; color: #FF0000;" id="ttlstock">
            Stock management</h1>
        <img src="carlogo.jpg" style="height: 101px; width : 332px; float:right" /><div>
        <div>
        </div>
        <asp:Button ID="btndelete" runat="server" style="z-index: 1; left: 229px; top: 252px; position: absolute; margin-bottom: 9px" Text="Delete stock" OnClick="btndelete_Click" />
        <asp:Button ID="btnedit" runat="server" style="z-index: 1; left: 122px; top: 253px; position: absolute" Text="Edit stock" OnClick="btnedit_Click" />
        <asp:ListBox ID="LstStock" runat="server" style="z-index: 1; left: 15px; top: 58px; position: absolute; height: 174px; width: 186px" OnSelectedIndexChanged="LstStock_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 231px; top: 69px; position: absolute" Text="Search"></asp:Label>
        <asp:Label ID="lblfilter" runat="server" style="z-index: 1; left: 233px; top: 100px; position: absolute" Text="Filter"></asp:Label>
        <asp:DropDownList ID="ddfilter" runat="server" style="z-index: 1; left: 289px; top: 100px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="txtsearch" runat="server" style="z-index: 1; left: 288px; top: 67px; position: absolute" OnTextChanged="txtsearch_TextChanged"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 297px; position: absolute"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnadd" runat="server" style="z-index: 1; left: 18px; top: 253px; position: absolute; margin-bottom: 2px;" Text="Add stock" OnClick="btnadd_Click" />
        </p>
    </form>
</body>
</html>
