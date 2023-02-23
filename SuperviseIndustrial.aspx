<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuperviseIndustrial.aspx.cs" Inherits="Milestone.SuperviseIndustrial" %>

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
            <asp:Label ID="Label2" runat="server" Text="Project Code"></asp:Label>
            <asp:TextBox ID="pjc" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Supervise" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
