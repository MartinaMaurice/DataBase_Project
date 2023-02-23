<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBachelorProjectGrades.aspx.cs" Inherits="Milestone.ViewBachelorProjectGrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="student_id"></asp:Label>
        </div>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="View Grade" OnClick="Button2_Click" />
    </form>
</body>
</html>
