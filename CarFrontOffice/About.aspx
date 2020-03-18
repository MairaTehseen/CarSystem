<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <img src="carlogo.jpg" style="height: 101px; width: 332px" />
        <asp:Label ID="lblAboutUs" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 358px; top: 69px; position: absolute" Text="About us"></asp:Label>
       
        <p>  
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
            
            Lorem ipsum dolor sit amet, nam id semper atomorum. Eius ipsum pertinacia mei eu. Ea graeci maluisset scripserit vix, te vim dicant periculis constituam, ut mel noster phaedrum. In mel quaeque eruditi pertinacia, sea ea odio decore principes, 
            alii etiam cu sit.

            Duis facer probatus no vix. Per eu sale liber ceteros. Ea cum vero essent reprehendunt, cum ei audire sanctus. Ubique dictas ad cum, dicit torquatos pro in. Congue intellegat id eam. Ipsum insolens rationibus id sea, usu modo fabellas invenire
            in. Ignota nominati recteque qui cu, id vis harum suavitate, graeco legimus ex vim.</p>
        
        <asp:Button ID="btnReturn" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="btnReturn_Click" style="z-index: 1; left: 518px; top: 349px; position: absolute" Text="Return" />

    </form>
</body>
</html>