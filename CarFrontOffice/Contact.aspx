<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <img src="carlogo.jpg" style="height: 101px; width: 332px" />
        <asp:Label ID="lblContact" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 347px; top: 66px; position: absolute" Text="Contact"></asp:Label>
    <p> Auto Car ltd </p>
        
        <p> 2020 De Montfort Street </p>
        <p>University Road</p>
        <p>Phone: 0123 4567891</p>
        <p>Support: AutoCarSupport@autocar.com</p>
    
    
        <asp:Button ID="btnBackToHome" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="btnBackToHome_Click" style="z-index: 1; left: 495px; top: 371px; position: absolute" Text="Back to Home" />
    
    
    </form>
</body>
</html>