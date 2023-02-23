<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EEGradeThesis.aspx.cs" Inherits="WebApplication.EEGradeThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EE_id:"></asp:Label>
            <br />
            <asp:TextBox ID="EE_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Sid:"></asp:Label>
            <br />
            <asp:TextBox ID="Sid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Thesis_title:"></asp:Label>
            <br />
            <asp:TextBox ID="Thesis_title" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="EE_grade:"></asp:Label>
            <br />
            <asp:TextBox ID="EE_grade" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Grade" />
        </div>
    </form>
</body>
</html>
