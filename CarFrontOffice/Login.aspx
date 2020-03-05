<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Company - Login</title>
    <link rel="stylesheet" type="text/css" href="style.css" media="screen"/>
</head>
<body style="margin:0px;background-color:white; padding:0px;height: 100%;">
    
    <form id="form1" runat="server">
    
        <div style="width:100%;background-color:blue;min-width:1200px">
            <div style="width:100%;background-color:black;height:160px">
                <div style="width:100%;background-color: rgb(46, 49, 146);height: 70px;z-index: 2;">
                    <div style="width:5%;text-align:center;padding-top:20px;float:left"> </div>
                      <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="HOME" runat="server" OnClick="HOME_Click">HOME</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="ABOUT" runat="server" OnClick="ABOUT_Click">ABOUT</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="CONTACT" runat="server" OnClick="CONTACT_Click">CONTACT</asp:LinkButton>
                      </div>
                    <div style="width:30%;text-align:center;padding-top:20px;float:left"> 
                        <img alt="LOGO" class="auto-style1" src="carlogo.png" /></div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="REGISTER" runat="server" OnClick="REGISTER_Click" >REGISTER</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="SETTINGS" runat="server" OnClick="SETTINGS_Click">SETTINGS</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(125, 125, 125); line-height: 1.2; " ID="LOGIN" runat="server" OnClick="LOGIN_Click">LOGIN</asp:LinkButton>
                      </div>
                    <div style="width:5%;text-align:center;padding-top:20px;float:left"> </div>
                    <div style="width:100%;text-align:center;float:left"> 
                        <asp:Label style="font-family: 'Britannic Bold'; color:aliceblue" ID="Label1" runat="server" Text="Logged in as :"></asp:Label>
                    </div>
                </div>
                </div>
            </div>


          
    </form>
</body>
</html>