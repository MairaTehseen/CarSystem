<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
      <img src="carlogo.jpg" style="height: 101px; width: 332px" />
        
        
   
          <asp:Label ID="lblLogin" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 11px; top: 147px; position: absolute" Text="Login."></asp:Label>
          <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 48px; top: 203px; position: absolute" Text="Email" Font-Size="Medium"></asp:Label>
          <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 114px; top: 202px; position: absolute; width: 204px"></asp:TextBox>
          <asp:Label ID="lblPassword" runat="server" Font-Size="Medium" style="z-index: 1; left: 15px; top: 251px; position: absolute" Text="Password"></asp:Label>
          <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 113px; top: 252px; position: absolute; width: 205px"></asp:TextBox>
          <asp:Button ID="btnLogin" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" style="z-index: 1; left: 215px; top: 322px; position: absolute; width: 107px; right: 1093px; height: 28px;" Text="Login" OnClick="btnLogin_Click" />
          <asp:HyperLink ID="hlinkRegisterCustomer" NavigateUrl="RegisterCustomer.aspx" runat="server" ForeColor="#3366FF" style="z-index: 1; left: 21px; top: 410px; position: absolute">Register</asp:HyperLink>
          <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 86px; top: 411px; position: absolute; width: 245px" Text="if you don't have an account"></asp:Label>
          <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 450px; position: absolute"></asp:Label>
          <asp:Button ID="btnCancel" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="btnCancel_Click" style="z-index: 1; left: 215px; top: 356px; position: absolute; width: 107px; height: 25px" Text="Cancel" />
      </form>
</body>
</html>