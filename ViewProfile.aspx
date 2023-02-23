<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Milestone.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="VP1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="125px" style="margin-left: 0px" Width="1377px">
            </asp:Panel>
            <br />
            <asp:Label ID="Label4" runat="server" Text="User ID: "></asp:Label>
            <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button12" runat="server" Text="View Profile!" Width="318px" OnClick="Button12_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View Bachelor Project" OnClick="Button1_Click" Width="318px" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="If you are registered as a company you can: "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Add Employee" Width="318px" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Create Local Project" Width="318px" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Assign Employee" Width="318px" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Grade Thesis" Width="318px" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Grade Defense" Width="318px" OnClick="Button6_Click" />
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="Grade Progress Report" Width="318px" OnClick="Button7_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="If you are registered as an Employee you can: "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button8" runat="server" Text="Grade Defense" Width="318px" OnClick="Button8_Click" />
            <br />
            <br />
            <asp:Button ID="Button9" runat="server" Text="Grade Thesis" Width="318px" OnClick="Button9_Click" />
            <br />
            <br />
            <asp:Button ID="Button10" runat="server" Text="Create Progress Report" Width="318px" OnClick="Button10_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="If you are registered as a Student you can: "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button11" runat="server" Text="Major Preferences" Width="318px" OnClick="Button11_Click" />
            <br />
            <br />
            <asp:Button ID="Button13" runat="server" Text="View Your Thesis" Width="318px" OnClick="Button13_Click" />
            <br />
            <br />
            <asp:Button ID="Button14" runat="server" Text="Submit My Thesis" Width="318px" OnClick="Button14_Click" />
            <br />
            <br />
            <asp:Button ID="Button15" runat="server" Text="View Progress Reports" Width="318px" OnClick="Button15_Click" />
            <br />
            <br />
            <asp:Button ID="Button16" runat="server" Text="View Defense" Width="318px" OnClick="Button16_Click" />
            <br />
            <br />
            <asp:Button ID="Button17" runat="server" Text=" Update Defense" Width="318px" OnClick="Button17_Click" />
            <br />
            <br />
            <asp:Button ID="Button18" runat="server" Text="BachelorProject Grade" Width="318px" OnClick="Button18_Click" />
            <br />
            <br />
            <asp:Button ID="Button19" runat="server" Text="Not Booked Meetings" Width="318px" OnClick="Button19_Click" />
            <br />
            <br />
            <asp:Button ID="Button20" runat="server" Text="Book Meeting" Width="318px" OnClick="Button20_Click" />
            <br />
            <br />
            <asp:Button ID="Button21" runat="server" Text="View Meetings" Width="318px" OnClick="Button21_Click" />
            <br />
            <br />
            <asp:Button ID="Button22" runat="server" Text="Add To Do In Meetings" Width="318px" OnClick="Button22_Click" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="If you are a Lecturer you can:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button23" runat="server" Text="Create bachelor project" Width="318px" OnClick="Button23_Click" />
            <br />
            <br />
            <asp:Button ID="Button24" runat="server" Text="Specify Deadline" Width="318px" OnClick="Button24_Click" />
            <br />
            <br />
            <asp:Button ID="Button25" runat="server" Text="(Lec) Create Meeting" Width="318px" OnClick="Button25_Click" />
            <br />
            <br />
            <asp:Button ID="Button26" runat="server" Text="Add to ToDo List" Width="318px" OnClick="Button26_Click" />
            <br />
            <br />
            <asp:Button ID="Button27" runat="server" Text="View Lec Meetings" Width="318px" OnClick="Button27_Click" />
            <br />
            <br />
            <asp:Button ID="Button28" runat="server" Text="View EE" Width="318px" OnClick="Button28_Click" />
            <br />
            <br />
            <asp:Button ID="Button29" runat="server" Text="Reccommend EE" Width="318px" OnClick="Button29_Click" />
            <br />
            <br />
            <asp:Button ID="Button30" runat="server" Text="Supervise Industrial" Width="318px" OnClick="Button30_Click" />
            <br />
            <br />
            <asp:Button ID="Button31" runat="server" Text="Grade Thesis" Width="318px" OnClick="Button31_Click" />
            <br />
            <br />
            <asp:Button ID="Button32" runat="server" Text="Grade Defense" Width="318px" OnClick="Button32_Click" />
            <br />
            <br />
            <asp:Button ID="Button33" runat="server" Text="Create Progress Report" Width="318px" OnClick="Button33_Click" />
            <br />
            <br />
            <asp:Button ID="Button34" runat="server" Text="Grade Progress Report" Width="318px" OnClick="Button34_Click" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="If you are a Coordinator you can:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button35" runat="server" Text="User Details" Width="318px" OnClick="Button35_Click" />
            <br />
            <br />
            <asp:Button ID="Button36" runat="server" Text="Assign Student" Width="318px" OnClick="Button36_Click" />
            <br />
            <br />
            <asp:Button ID="Button37" runat="server" Text="Assign TA" Width="318px" OnClick="Button37_Click" />
            <br />
            <br />
            <asp:Button ID="Button38" runat="server" Text="View Reccommendation" Width="318px" OnClick="Button38_Click" />
            <br />
            <br />
            <asp:Button ID="Button39" runat="server" Text="Assign EE" Width="318px" OnClick="Button39_Click" />
            <br />
            <br />
            <asp:Button ID="Button40" runat="server" Text="Schedule Defenses" Width="318px" OnClick="Button40_Click" />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="If you are a TA, you can:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button41" runat="server" Text="Create Progress Reports" Width="318px" OnClick="Button41_Click" />
            <br />
            <br />
            <asp:Button ID="Button42" runat="server" Text="Add to Meeting ToDo" Width="318px" OnClick="Button42_Click" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="If you are a EE you can:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button43" runat="server" Text="Grade Thesis" Width="318px" OnClick="Button43_Click" />
            <br />
            <br />
            <asp:Button ID="Button44" runat="server" Text="Grade Defense" Width="318px" OnClick="Button44_Click" />
            <br />
        </div>
    </form>
</body>
</html>
