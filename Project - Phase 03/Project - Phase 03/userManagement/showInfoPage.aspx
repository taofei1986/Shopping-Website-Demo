<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showInfoPage.aspx.cs" Inherits="Project___Phase_03.showInfoPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        first name:<asp:Label ID="lb_firstName" runat="server"></asp:Label><br/><br/>
        last name:<asp:Label ID="lb_lastName" runat="server"></asp:Label><br/><br/>
        username:<asp:Label ID="lb_username" runat="server"></asp:Label><br/><br/>
        password:<asp:Label ID="lb_password" runat="server"></asp:Label><br/><br/>
        address:<asp:Label ID="lb_address" runat="server"></asp:Label><br/><br/>
        email:<asp:Label ID="lb_email" runat="server"></asp:Label><br/><br/>
        phone number:<asp:Label ID="lb_phoneNumber" runat="server"></asp:Label><br/><br/>

    </div>
    </form>
</body>
</html>
