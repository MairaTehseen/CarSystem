<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment_Details.aspx.cs" Inherits="PayMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <body>
    <form id="form1" runat="server">   
        <div style="font-size:25px;text-align:center;padding-bottom:40px"><asp:Label ID="Label1" runat="server" Text="Welcome "></asp:Label><div style="font-weight:800;color:forestgreen"><asp:Label ID="username" runat="server" Text="User Name "></asp:Label></div><asp:Label ID="main" runat="server" Text="Deal with your payment
            here"></asp:Label></div>
        <div style="width:100%;float:none;text-align:left"><asp:Label ID="Label3" runat="server" Text="Cards"></asp:Label></div>
            
        

        <div style="width:100%;float:left">
        <div style="width:30%;float:left"><asp:ListBox ID="lstCards" runat="server" Width="100%"></asp:ListBox></div>

           <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button1" runat="server" Text="Add new" OnClick="Button1_Click"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button2" runat="server" Text="Edit"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click"  /></div>
            <div style="width:80px;padding-left:5%;padding-top:10px;float:none"> <asp:Label ID="lbl2Error" runat="server"></asp:Label></div>
            </div>
        <div style="width:100%;float:none;text-align:left"><asp:Label ID="Label5" runat="server" Text="Accounts"></asp:Label></div>
        <div style="width:30%;float:left"><asp:ListBox ID="ListAccounts" runat="server" Width="100%"></asp:ListBox></div>

           <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button4" runat="server" Text="Add new" OnClick="Button4_Click1"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button5" runat="server" Text="Edit"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button6" runat="server" Text="Delete" OnClick="Button6_Click"  /></div>
            <div style="width:80px;padding-left:5%;padding-top:10px;float:none"> <asp:Label ID="Label4" runat="server"></asp:Label></div>
            
        <div style="width:100%;float:left"><asp:Label ID="Label2" runat="server" Text="Pay For"></asp:Label></div>
         <div style="width:100%;float:left"><asp:ListBox style="float:left" Width="30%" ID="ListBox1" runat="server"></asp:ListBox>
            
             
             <asp:DropDownList style="float:left" ID="PaymentMethod" Width="140px" runat="server">
                 <asp:ListItem>Card</asp:ListItem>
                 <asp:ListItem>Account</asp:ListItem>
             </asp:DropDownList>
                 <asp:Label ID="Label6" runat="server" Text="Choose Payment Method"></asp:Label>
             <asp:Button style="float:left" ID="Button7" Width="140px" runat="server" Text="Pay" OnClick="Button7_Click" />
             
             
        </div>
    </form>
</body>
   
</body>
</html>
