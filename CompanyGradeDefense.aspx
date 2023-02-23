<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyGradeDefense.aspx.cs" Inherits="Milestone.CompanyGradeDefense" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="CompanyID: "></asp:Label>
            <asp:TextBox ID="c_id" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="home" runat="server" OnClick="Button2_Click" Text="Home" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="StudentID: "></asp:Label>
            <asp:TextBox ID="s_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Defense Location: "></asp:Label>
            <asp:TextBox ID="loc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Company Grade: "></asp:Label>
            <asp:TextBox ID="Cgrade" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="grade" runat="server" Text="Grade" OnClick="Button1_Click" />
    
        </div>
    </form>
</body>
</html>
