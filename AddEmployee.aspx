<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Milestone.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Company_ID: "></asp:Label>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="mail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="PhoneNumber: "></asp:Label>
            <asp:TextBox ID="num" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Field: "></asp:Label>
            <asp:TextBox ID="field" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="add" runat="server" Text="ADD" OnClick="add_Click" Width="261px" />
        </div>
    </form>
</body>
</html>
