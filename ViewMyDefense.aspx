<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyDefense.aspx.cs" Inherits="Milestone.ViewMyDefense" %>

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
            <asp:Button ID="Button1" runat="server" Text="View Defense" OnClick="Button1_Click" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
