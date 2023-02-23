<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TAAddToDo.aspx.cs" Inherits="WebApplication.TAAddToDo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Meeting_id:"></asp:Label>
            <br />
            <asp:TextBox ID="Meeting_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="To_do_list:"></asp:Label>
            <br />
            <asp:TextBox ID="To_do_list" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" />
        </div>
    </form>
</body>
</html>
