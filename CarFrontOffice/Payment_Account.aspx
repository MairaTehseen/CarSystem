<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment_Account.aspx.cs" Inherits="Payment_Card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:15%; float:left; height: 67px;">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Account Holder :"></asp:Label>
            
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Account Number :"></asp:Label>
            
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Bank Name :"></asp:Label>
            
        </div>
            </div>
         <div style="width:30%; float:left">
        <div>
            
            <asp:TextBox ID="txtAccountHolder" runat="server" Width="156px"></asp:TextBox>
        </div>
        <div>
             <asp:TextBox ID="txtAccountNumber" runat="server" Width="156px"></asp:TextBox>
            
        </div>
        <div>
             <asp:TextBox ID="BankName" runat="server" Width="155px" style="margin-top: 1px"></asp:TextBox>
            
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
