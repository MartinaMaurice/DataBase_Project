<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMeetingLecturer.aspx.cs" Inherits="Milestone.ViewMeeting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Meeting ID"></asp:Label>
            <asp:TextBox ID="mid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Lecturer ID"></asp:Label>
            <asp:TextBox ID="lid" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
