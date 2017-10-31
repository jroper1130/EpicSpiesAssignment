<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 164px;
            height: 190px;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="download.png" /><br />
            <br />
            <strong><span class="auto-style2">Spy New Assingment Form</span></strong><br />
            <br />
            Spy Code Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
