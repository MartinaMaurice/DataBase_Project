<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMeetings.aspx.cs" Inherits="Milestone.ViewMeetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="meeting_id"></asp:Label>
        </div>
        <asp:TextBox ID="m_id" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="student_id"></asp:Label>
        </p>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="View Meetings" OnClick="Button1_Click" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
