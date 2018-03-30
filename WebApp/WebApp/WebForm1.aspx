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
            <asp:Label ID="conditions" runat="server" Text="Weather Conditions"></asp:Label>
            <br />
            <br />
            <asp:Label ID="DailyWeatherCondition" runat="server" Text="Daily weather condition: "></asp:Label>
            <br />
            <asp:Label ID="DailyTemp" runat="server" Text="Daily High and Low Temp: "></asp:Label>
            <br />
            <asp:Label ID="CurrentTemp" runat="server" Text="Current Temperature: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="HourlyLayout" runat="server" Text="Hour,temp,condition:"></asp:Label>
            <br />
            <asp:Label ID="Hourly" runat="server" Text="Hourly: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="MultiDay" runat="server" Text="Weather for the week: "></asp:Label>
            <br />
            <asp:Label ID="HighLow" runat="server" Text="HighTemp:LowTemp"></asp:Label>
            <br />
            <asp:Label ID="DailyTemperatures" runat="server" Text="Daily Temperatures"></asp:Label>
            <br />
            <br />
            <asp:Label ID="NiceDaysOfWeek" runat="server" Text="Nice Days of the week are clear"></asp:Label>
            <br />
            <asp:Label ID="NiceDaysLabel" runat="server" Text="Nice Days: "></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
