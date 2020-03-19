<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Company - Register</title>
    <link rel="stylesheet" type="text/css" href="style.css" media="screen"/>
    <style type="text/css">
        
        .auto-style1 {
            height: ;
        }
        
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 30px;
        }
        
    </style>
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
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(125, 125, 125); line-height: 1.2; " ID="REGISTER" runat="server" OnClick="REGISTER_Click" >REGISTER</asp:LinkButton>
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        
                      </div>
                    <div style="width:10%;text-align:center;padding-top:20px;float:left"> 
                        <asp:LinkButton style="text-decoration: none;font-size: 22px;font-family: 'Britannic Bold'; color: rgb(255, 255, 255); line-height: 1.2; " ID="LOGIN" runat="server" OnClick="LOGIN_Click">LOGIN</asp:LinkButton>
                      </div>
                    <div style="width:5%;text-align:center;padding-top:20px;float:left"> </div>
                    <div id="MENULOGIN" style="float:left;width:30%;padding-top:24px;padding-right:30px"> 
                        <div  style="text-align:center;height:25px;">
                        <asp:Label style="font-family: 'Britannic Bold'; color:aliceblue" ID="Label1" runat="server" Text="Logged in as :"></asp:Label>
                        </div>

                        <div style="float:none;height:25px;text-align:center;display: flex;justify-content:space-around;padding-top:10px;">
                            <div style="float:left">
                        <asp:LinkButton style="text-decoration: none;font-family: 'Britannic Bold'; color:aliceblue" ID="PaymentDetails" runat="server" OnClick="PaymentDetails_Click">  Payment  </asp:LinkButton>
                        </div>
                            <div style="float:left">
                            <asp:LinkButton style="text-decoration: none; font-family: 'Britannic Bold'; color: aliceblue" ID="Basket" runat="server">  Basket </asp:LinkButton>
                           </div>
                            <div style="float:left">
                            <asp:LinkButton style="text-decoration: none;font-family: 'Britannic Bold'; color:aliceblue" ID="Settings" runat="server"> Settings </asp:LinkButton>
                        </div>


                        </div>

                        <div style="text-align:center;float:none;height:25px;padding-top:10px;">
                        <asp:LinkButton style="text-decoration: none;font-family: 'Britannic Bold'; color:firebrick" ID="LOGOUT" runat="server" OnClick="LOGOUT_Click">Logout</asp:LinkButton>
                        </div>
                    </div>
                </div>
                </div>
            </div>


          
        <table>
            <tr>
                <td align="right">First Name : </td>
                <td>
                    <asp:TextBox ID="TextBoxfn" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">Last Name :</td>
                <td>
                    <asp:TextBox ID="TextBoxln" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">Country :</td>
                <td>
                    <asp:TextBox ID="TextBoxcr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">City :</td>
                <td>
                    <asp:TextBox ID="TextBoxct" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">Street :</td>
                <td>
                    <asp:TextBox ID="TextBoxst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="right">House Number :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxhn" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="right">Post Code :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxpc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="right">User Name :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxun" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="right">Password#1 :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxp1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="right">Password#2 :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBoxp2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">E-Mail Address:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxea" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" align="right">
                    <asp:Button ID="RegisterBTN" runat="server" Text="Register" OnClick="RegisterBTN_Click" />
                </td>
                <td class="auto-style3">
                   
                    <asp:Button ID="StaffRegisterBTN" runat="server" Text="Register As Staff" Visible="False" OnClick="StaffRegisterBTN_Click" />
                </td>
            </tr>
        </table>


          
    </form>
</body>
</html>