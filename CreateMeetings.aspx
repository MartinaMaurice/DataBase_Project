<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMeetings.aspx.cs" Inherits="Milestone.CreateMeetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="lecturer_id"></asp:Label>
            <asp:TextBox ID="lid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="start-time
                "></asp:Label>
            <asp:TextBox ID="stime" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="end-time"></asp:Label>
            <asp:TextBox ID="etime" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="date"></asp:Label>
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="meeting point"></asp:Label>
            <asp:TextBox ID="mid" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
