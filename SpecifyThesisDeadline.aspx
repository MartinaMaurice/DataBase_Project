<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpecifyThesisDeadline.aspx.cs" Inherits="Milestone.SpecifyThesisDeadline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Deadline: "></asp:Label>
            <asp:TextBox ID="Deadline" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Specify Deadline" Width="252px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
