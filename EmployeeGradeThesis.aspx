<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeGradeThesis.aspx.cs" Inherits="Milestone.EmployeeGradeThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="EmployeeID: "></asp:Label>
            <asp:TextBox ID="E_id" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="StudentID: "></asp:Label>
            <asp:TextBox ID="s_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Thesis Title: "></asp:Label>
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Employee Grade: "></asp:Label>
            <asp:TextBox ID="Egrade" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Grade" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
