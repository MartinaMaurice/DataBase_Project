<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToDoInMeetings.aspx.cs" Inherits="Milestone.AddToDoInMeetings" %>

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
            <asp:Label ID="Label2" runat="server" Text="to_do_list"></asp:Label>
        </p>
        <asp:TextBox ID="to_do" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add To_Do_list" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
