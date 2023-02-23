<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LecturerAddToDo.aspx.cs" Inherits="Milestone.LecturerAddToDo" %>

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
            <asp:Label ID="Label2" runat="server" Text="ToDo List"></asp:Label>
            <asp:TextBox ID="todo" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add to ToDo" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
