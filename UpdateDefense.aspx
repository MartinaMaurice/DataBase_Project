<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDefense.aspx.cs" Inherits="Milestone.UpdateDefense" %>

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
        <p>
            <asp:Label ID="Label2" runat="server" Text="defense_content"></asp:Label>
        </p>
        <asp:TextBox ID="dcontent" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update Defense" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
