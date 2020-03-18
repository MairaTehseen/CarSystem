<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberHome.aspx.cs" Inherits="MemberHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
        <img src="carlogo.jpg" style="height: 101px; width: 332px" />
        <asp:Label ID="lblMemberWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 1099px; top: 38px; position: absolute" Text="Welcome, Member"></asp:Label>
        <asp:Label ID="lblMemberOptions" runat="server" style="z-index: 1; left: 1228px; top: 94px; position: absolute" Text="Your options:"></asp:Label>
        <asp:Button ID="btnUpdateDetails" runat="server" style="z-index: 1; left: 1155px; top: 138px; position: absolute; width: 225px" Text="Update personal details" OnClick="btnUpdateDetails_Click" />
        <asp:Button ID="btnDeleteDetails" runat="server" style="z-index: 1; left: 1159px; top: 222px; position: absolute; width: 220px" Text="Delete personal details" OnClick="btnDeleteDetails_Click" />
    
         <asp:TextBox ID="txtbxsearch" runat="server" ForeColor="Silver" style="z-index: 1; left: 366px; top: 187px; position: absolute; height: 31px; width: 322px">Search by brand name, car name ...</asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 734px; top: 187px; position: absolute; width: 148px; height: 35px" Text="Search" />
        
        
    
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 373px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 1298px; top: 335px; position: absolute" Text="Log out" OnClick="btnLogout_Click" />
        
        
    
    </form>
</body>
</html>
