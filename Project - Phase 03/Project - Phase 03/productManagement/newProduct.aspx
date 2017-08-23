<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newProduct.aspx.cs" Inherits="Project___Phase_03.productManagement.newProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <div id="top">
        Welecom to Toffee Studio
    </div>

    <div id="navigation">
        -Home<br/>
        -Photos<br/>
    </div>

    <form id="newProductForm" runat="server">
        Product Name:<asp:TextBox ID="txtb_pdtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator class="Validator" runat="server" ControlToValidate="txtb_pdtName" ErrorMessage="Please enter the product name."></asp:RequiredFieldValidator><br/>

        Description:<asp:TextBox ID="txtb_pdtDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator class="Validator" runat="server" ControlToValidate="txtb_pdtDescription" ErrorMessage="Please enter the product description."></asp:RequiredFieldValidator><br/>

        Price:<asp:TextBox ID="txtb_pdtPrice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator class="Validator" runat="server" ControlToValidate="txtb_pdtPrice" ErrorMessage="Please enter the product price."></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator  class="Validator" runat="server" ControlToValidate="txtb_pdtPrice" ErrorMessage="Not a valid price." ValidationExpression="^[+]?([.]\d+|\d+([.]\d+)?)$"></asp:RegularExpressionValidator><br/>

        Amount:<asp:TextBox ID="txtb_pdtAmount" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator class="Validator" runat="server" ControlToValidate="txtb_pdtAmount" ErrorMessage="Please enter the amount."></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator class="Validator"  runat="server" ControlToValidate="txtb_pdtAmount" ErrorMessage="Not a valid amount." ValidationExpression="^[1-9]\d*$"></asp:RegularExpressionValidator><br/>

        <asp:Button Text="Submit" runat="server" onclick="Unnamed_Click"/>
    </form>

    <div id="footer">
        Copyright-contact
    </div>
</body>
</html>
