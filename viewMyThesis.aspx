<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewMyThesis.aspx.cs" Inherits="Milestone.viewMyThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="student_id"></asp:Label>
        </div>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="title"></asp:Label>
        </p>
        <asp:TextBox ID="title1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="view" OnClick="Button1_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
