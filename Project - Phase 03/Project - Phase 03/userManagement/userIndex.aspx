<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userIndex.aspx.cs" Inherits="Project___Phase_03.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        First Name:<asp:TextBox ID="txtb_firstName" runat="server"></asp:TextBox><br/><br/>
        Last Name:<asp:TextBox ID="txtb_lastName" runat="server"></asp:TextBox><br/><br/>
        Username:<asp:TextBox ID="txtb_username" runat="server"></asp:TextBox><br/><br/>
        Password:<asp:TextBox ID="txtb_password" runat="server"></asp:TextBox><br/><br/>
        Address:<asp:TextBox ID="txtb_address" runat="server"></asp:TextBox><br/><br/>
        Email:<asp:TextBox ID="txtb_email" runat="server"></asp:TextBox><br/><br/>
        Phone number:<asp:TextBox ID="txtb_phoneNumber" runat="server"></asp:TextBox><br/><br/>
        <asp:Button Text="Submit" runat="server" PostBackUrl="~/secondPage.aspx"/>
    </div>
    </form>
</body>
</html>
