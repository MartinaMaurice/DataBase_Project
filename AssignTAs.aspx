<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignTAs.aspx.cs" Inherits="WebApplication.AssignTAs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="coordinator_id:"></asp:Label>
        <div>
            <asp:TextBox ID="coordinator_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="TA_id:"></asp:Label>
            <br />
            <asp:TextBox ID="TA_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="proj_code:"></asp:Label>
            <br />
            <asp:TextBox ID="proj_code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Assign" />
        </div>
    </form>
</body>
</html>
