<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment_Card.aspx.cs" Inherits="Payment_Card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:15%; float:left">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Card Holder :"></asp:Label>
            
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Card Number :"></asp:Label>
            
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Expire Date :"></asp:Label>
            
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Seciurity Code :"></asp:Label>
            
        </div>
            </div>
         <div style="width:30%; float:left">
        <div>
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
        </div>
        <div>
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            
        </div>
        <div>
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
        </div>
            </div>
        
    </form>
</body>
</html>
