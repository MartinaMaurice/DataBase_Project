<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleDefense.aspx.cs" Inherits="WebApplication.ScheduleDefense" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="sid:"></asp:Label>
            <br />
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="date:"></asp:Label>
            <br />
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="time:"></asp:Label>
            <br />
            <asp:TextBox ID="time" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="loc:"></asp:Label>
            <br />
            <asp:TextBox ID="loc" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Create" />
        </div>
    </form>
</body>
</html>
