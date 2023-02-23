<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignE.aspx.cs" Inherits="WebApplication.AssignE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cid:"></asp:Label>
            <br />
            <asp:TextBox ID="Cid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="EE_id:"></asp:Label>
            <br />
            <asp:TextBox ID="EE_id" runat="server"></asp:TextBox>
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
