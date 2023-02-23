<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LecGradeThesis.aspx.cs" Inherits="Milestone.LecGradeThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Lecturer ID"></asp:Label>
            <asp:TextBox ID="lid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Thesis Title"></asp:Label>
            <asp:TextBox ID="tht" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Lecturer Grade"></asp:Label>
            <asp:TextBox ID="lg" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Grade" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
