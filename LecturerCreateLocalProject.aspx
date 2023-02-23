<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LecturerCreateLocalProject.aspx.cs" Inherits="Milestone.LecturerCreateLocalProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Lecturer_id: "></asp:Label>

            <asp:TextBox ID="LID" runat="server"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

            <br />
            <asp:Label ID="Label2" runat="server" Text="ProjectCode: "></asp:Label>
            <asp:TextBox ID="PC" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Title: "></asp:Label>
            <asp:TextBox ID="tt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Description: "></asp:Label>
            <asp:TextBox ID="Desc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Major Code: "></asp:Label>
            <asp:TextBox ID="MCode" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Create Local Project" Width="362px" OnClick="Button1_Click" />
            <br />

        </div>
    </form>
</body>
</html>
