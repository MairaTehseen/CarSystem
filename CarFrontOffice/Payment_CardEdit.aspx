<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment_CardEdit.aspx.cs" Inherits="Payment_Card" %>

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
            
            <asp:TextBox ID="txtCardHolder" runat="server" Width="156px"></asp:TextBox>
        </div>
        <div>
             <asp:TextBox ID="txtCardNumber" runat="server" Width="156px"></asp:TextBox>
            
        </div>
        <div>
             <asp:TextBox ID="txtYear" runat="server" Width="78px">Year (0000)</asp:TextBox>
            
             <asp:TextBox ID="txtMonth" runat="server" Width="70px">Month (00)</asp:TextBox>
            
        </div>
        <div>
             <asp:TextBox ID="txtsecuritycode" runat="server" Width="155px"></asp:TextBox>
            
        </div>
            </div>
        <div style="float:none">
        <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
            </div>
        <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
        
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
        
    </form>
</body>
</html>
