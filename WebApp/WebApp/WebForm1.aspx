<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblState" runat="server" Text="Please enter your State(2 letters): "></asp:Label>
        &nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCity" runat="server" Text="Please enter your City: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="What's my weather?" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="conditions" runat="server" Text="Weather Condtions"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Daily" runat="server" Text="Daily"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Hourly" runat="server" Text="Hourly"></asp:Label>
            <br />
            <br />
            <asp:Label ID="MultiDay" runat="server" Text="MultiDay"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
