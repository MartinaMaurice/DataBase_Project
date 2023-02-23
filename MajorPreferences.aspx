<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MajorPreferences.aspx.cs" Inherits="Milestone.MajorPreferences" %>

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
        <asp:Label ID="Label2" runat="server" Text="bachelor_code"></asp:Label>
        <br />
        <asp:TextBox ID="bcode" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="preference_number"></asp:Label>
        <br />
        <asp:TextBox ID="pnumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="make preference" OnClick="Button1_Click" />
    </form>
</body>
</html>
