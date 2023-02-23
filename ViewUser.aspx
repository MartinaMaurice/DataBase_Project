<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="WebApplication.login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User_type:"></asp:Label>
            <br />
            <asp:TextBox ID="User_type" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="User_id:"></asp:Label>
            <br />
            <asp:TextBox ID="User_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
