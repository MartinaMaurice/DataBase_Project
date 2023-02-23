<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TACreatePR.aspx.cs" Inherits="WebApplication.TACreatePR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="TA_id:"></asp:Label>
            <br />
            <asp:TextBox ID="TA_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Sid:"></asp:Label>
            <br />
            <asp:TextBox ID="Sid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Date:"></asp:Label>
            <br />
            <asp:TextBox ID="Date" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Content:"></asp:Label>
            <br />
            <asp:TextBox ID="Content" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create" />
        </div>
    </form>
</body>
</html>
