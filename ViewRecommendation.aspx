<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRecommendation.aspx.cs" Inherits="WebApplication.ViewRecommendation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="lecturer_id:"></asp:Label>
            <br />
            <asp:TextBox ID="lecturer_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
