<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookMeetings.aspx.cs" Inherits="Milestone.BookMeetings" %>

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
        <br />
        <asp:Label ID="Label2" runat="server" Text="meeting_id"></asp:Label>
        <p>
            <asp:TextBox ID="m_id" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Book Your Meeting" OnClick="Button1_Click" />
    </form>
</body>
</html>
