<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatePage.aspx.cs" Inherits="Project___Phase_03.updatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Please update your information</h1>
        First Name:<asp:TextBox ID="txtb_updatefirstName" runat="server"></asp:TextBox><br/><br/>
        Last Name:<asp:TextBox ID="txtb_updatelastName" runat="server"></asp:TextBox><br/><br/>
        Username:<asp:TextBox ID="txtb_updateusername" runat="server"></asp:TextBox><br/><br/>
        Password:<asp:TextBox ID="txtb_updatepassword" runat="server"></asp:TextBox><br/><br/>
        Address:<asp:TextBox ID="txtb_updateaddress" runat="server"></asp:TextBox><br/><br/>
        Email:<asp:TextBox ID="txtb_updateemail" runat="server"></asp:TextBox><br/><br/>
        Phone number:<asp:TextBox ID="txtb_updatephoneNumber" runat="server"></asp:TextBox><br/><br/>
        <asp:Button Text="Submit" runat="server" onclick="Unnamed_Click"/>
    </div>
    </form>
</body>
</html>
