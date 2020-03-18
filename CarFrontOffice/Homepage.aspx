<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
</head>
<body>
    <form id="form1" runat="server">
  
            <img src="carlogo.jpg" style="height: 101px; width: 332px" />
        
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 337px; top: 75px; position: absolute; width: 129px; height: 36px;" Text="Home" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnHome_Click" BorderColor="Black" Height="36px" Width="129px" BorderStyle="None" />
            <asp:Button ID="btnAbout" runat="server" BackColor="Black" Font-Bold="True" ForeColor="White" Height="36px" style="z-index: 1; left: 465px; top: 75px; position: absolute; width: 128px" Text="About" Width="129px" BorderColor="Black" BorderStyle="None" OnClick="btnAbout_Click" />
        
        
  
        
            <asp:Button ID="btnContact" runat="server" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="36px" style="z-index: 1; left: 593px; top: 75px; position: absolute; right: 693px;" Text="Contact" Width="129px" BorderStyle="None" OnClick="btnContact_Click" />
        
        
  
        
            <asp:TextBox ID="txtbxsearch" runat="server" ForeColor="Silver" style="z-index: 1; left: 366px; top: 187px; position: absolute; height: 31px; width: 322px">Search by brand name, car name ...</asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 734px; top: 187px; position: absolute; width: 148px; height: 35px" Text="Search" />
        
        
  
        
            <asp:ListBox ID="lstbxCars" runat="server" style="z-index: 1; left: 452px; top: 273px; position: absolute; width: 380px"></asp:ListBox>
            <asp:Button ID="btnBlank" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Height="36px" style="z-index: 1; left: 721px; top: 75px; position: absolute; width: 250px" Text="Butto" Width="129px" OnClick="btnBlank_Click" />
            <asp:Button ID="btnStaffLogin" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="36px" style="z-index: 1; left: 971px; top: 75px; position: absolute" Text="Admin Login" Width="129px" OnClick="btnStaffLogin_Click" />
            <asp:Button ID="btnRegister" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="36px" style="z-index: 1; left: 1098px; top: 75px; position: absolute" Text="Register" Width="129px" OnClick="btnRegister_Click" />
            <asp:Button ID="btnCustomerLogin" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="36px" OnClick="btnCustomerLogin_Click" style="z-index: 1; left: 1226px; top: 75px; position: absolute" Text="Login" Width="129px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 622px; position: absolute"></asp:Label>
        
        
  
        
    </form>
</body>
</html>

