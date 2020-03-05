<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Company</title>
    <link rel="stylesheet" type="text/css" href="style.css" media="screen"/>
</head>
<body style="margin:0px;background-color:white; padding:0px;height: 100%;">
    
    <form id="form1" runat="server">
    
        <div style="width:100%;background-color:blue;min-width:1200px">
            <div style="width:100%;background-color:black;height:160px">
                <div style="width:100%;background-color: rgb(46, 49, 146);height: 70px;z-index: 2;">
                    <div style="width:5%;text-align:center;padding-top:20px;float:left"> </div>
                      <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="HOME" runat="server">HOME</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="ABOUT" runat="server">ABOUT</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="CONTACT" runat="server">CONTACT</asp:LinkButton>
                      </div>
                    <div style="width:30%;text-align:center;padding-top:20px;float:left"> 
                        <img alt="LOGO" class="auto-style1" src="carlogo.png" /></div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="LinkButton2" runat="server">REGISTER</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="LinkButton3" runat="server">SETTINGS</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="LinkButton1" runat="server">LOGIN</asp:LinkButton>
                      </div>
                    <div style="width:5%;text-align:center;padding-top:20px;float:left"> </div>
                </div>
                </div>
            </div>


          
    </form>
</body>
</html>




