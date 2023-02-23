<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="Milestone.Sign_Up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height = 1221px">
    <form id="Sign_Up" runat="server">
         <asp:Label ID="Label1" runat="server" Text="Professions: "></asp:Label>
        <asp:DropDownList ID="UserType" runat="server" style="margin-left: 27px" Width="333px">
            <asp:ListItem>Student</asp:ListItem>
            <asp:ListItem>Lecturer</asp:ListItem>
            <asp:ListItem>Teaching_Assistant</asp:ListItem>
            <asp:ListItem>External_Examiner</asp:ListItem>
            <asp:ListItem>Coordinator</asp:ListItem>
            <asp:ListItem>Company</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name:
            <asp:TextBox ID="First_Name" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name:
            <asp:TextBox ID="Last_Name" runat="server"></asp:TextBox>
        </p>
        <p>
            BirthDate:
            <asp:TextBox ID="Birthdate" runat="server"></asp:TextBox>
        </p>
        <p>
            GPA:
            <asp:TextBox ID="GPA" runat="server"></asp:TextBox>
        </p>
        <p>
            Semester:
            <asp:TextBox ID="Semester" runat="server"></asp:TextBox>
        </p>
        <p>
            Address:&nbsp;
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
        </p>
        <p>
            Faculty Code:
            <asp:TextBox ID="Faculty_Code" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Major Code:
            <asp:TextBox ID="Major_Code" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Company Name:
            <asp:TextBox ID="Company_Name" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Representative_Name:
            <asp:TextBox ID="Representative_Name" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Representative_Email:<asp:TextBox ID="Representative_Email" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Phone_Number:
            <asp:TextBox ID="Phone_Number" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            Country_Of_Residence:
            <asp:TextBox ID="Country_Of_Residence" runat="server"></asp:TextBox>
        </p>
        <p style="direction: ltr">
            <asp:Button ID="CreateAcc" runat="server" OnClick="SignUp" style="margin-left: 77px" Text="Create Account" Width="350px" />
        </p>
        <p style="direction: ltr">
            &nbsp;</p>
        <p style="direction: ltr">
            &nbsp;</p>
        <p style="direction: ltr">
            &nbsp;</p>
        <p style="direction: ltr">
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
