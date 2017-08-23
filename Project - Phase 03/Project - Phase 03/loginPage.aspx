<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="Project___Phase_03.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>

    <div id="top">
        Welecom to Toffee Studio
    </div>

    <div id="navigation">
        -Home<br/>
        -Photos<br/>
    </div>

    <form id="userForm" runat="server">
        <div id="login" runat="server">
            Username:<br/>
            <asp:TextBox ID="txtb_username" runat="server"></asp:TextBox><br/>
            Password<br/>
            <asp:TextBox ID="txtb_password" runat="server" TextMode="Password"></asp:TextBox><br/>
            <asp:Button Text="Submit" runat="server" OnClick="Unnamed_Click"/>    <a href="userManagement/userIndex.aspx" id="signUp">Sign up</a><br/>
            <asp:label ID="lb_loginNotice" runat="server"></asp:label><br/>
        </div>            
        <div id="loginMenu" runat="server">
            <asp:label ID="lb_message" runat="server"></asp:label><br/>
            <a href="productManagement/newProduct.aspx">Add new product</a><br/>
            <a href="shopping/product.aspx">Show all product</a>
        </div>
       </form>

    <div id="footer">
        Copyright-contact
    </div>
</body>
</html>
