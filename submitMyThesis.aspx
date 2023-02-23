<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitMyThesis.aspx.cs" Inherits="Milestone.submitMyThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="sid"></asp:Label>
        </div>
        <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="title"></asp:Label>
        </p>
        <asp:TextBox ID="title1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="PDF_document"></asp:Label>
        </p>
        <asp:TextBox ID="PDF_doc" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
