<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Card.aspx");
    }
</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        <div style="font-size:25px;text-align:center;padding-bottom:40px"><asp:Label ID="Label1" runat="server" Text="Welcome "></asp:Label><div style="font-weight:800;color:forestgreen"><asp:Label ID="username" runat="server" Text="User Name "></asp:Label></div><asp:Label ID="main" runat="server" Text="Deal with your payment details here"></asp:Label></div>
        <div style="width:50%;float:left;text-align:center"><asp:Label ID="Label2" runat="server" Text="Bank Details"></asp:Label></div>
        <div style="width:50%;float:left;text-align:center"><asp:Label ID="Label3" runat="server" Text="Cards"></asp:Label></div>
            
        

        <div style="width:50%;float:left">
        <div style="width:50%;float:left"><asp:ListBox ID="ListBox1" runat="server" Width="100%"></asp:ListBox></div>

            <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button4" runat="server" Text="Add new" OnClick="Button4_Click"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button5" runat="server" Text="Edit"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button6" runat="server" Text="Delete"  /></div>
            </div>

        <div style="width:50%;float:left">
        <div style="width:50%;float:left"><asp:ListBox ID="ListBox2" runat="server" Width="100%"></asp:ListBox></div>

           <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button1" runat="server" Text="Add new"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button2" runat="server" Text="Edit"  /></div>
             <div style="padding-left:5%;padding-top:10px;float:left"> <asp:Button ID="Button3" runat="server" Text="Delete"  /></div>
            </div>
    </form>
</body>
</html>
