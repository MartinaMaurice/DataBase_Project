<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyCreateLocalProject.aspx.cs" Inherits="Milestone.CompanyCreateLocalProject" %>

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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Project Code: "></asp:Label>
            <asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Project Title: "></asp:Label>
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Project Description: "></asp:Label>
            <asp:TextBox ID="desc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Major Code: "></asp:Label>
            <asp:TextBox ID="Mcode" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="create" runat="server" Text="Create" OnClick="add_Click" Width="222px" />
      
        </div>
    </form>
</body>
</html>
