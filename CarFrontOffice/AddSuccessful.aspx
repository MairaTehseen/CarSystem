<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSuccessful.aspx.cs" Inherits="AddSuccessfully" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color: #000000; background-color: #CCCCCC">
    <form id="form1" runat="server">
        <img src="carlogo.jpg" style="height: 101px; width : 332px; float:right" /><div>
        <div>
            The record has been added successfully.<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 16px; position: absolute; top: 51px; height: 24px; width: 34px" Text="OK" />
        </div>
    </form>
</body>
</html>
