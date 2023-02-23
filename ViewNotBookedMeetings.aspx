<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewNotBookedMeetings.aspx.cs" Inherits="Milestone.ViewNotBookedMeetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Student_ID: "></asp:Label>

            <asp:TextBox ID="SID" runat="server"></asp:TextBox>

            <br />
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="View Not Booked Meeting" OnClick="Button1_Click" Width="398px" />

        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
