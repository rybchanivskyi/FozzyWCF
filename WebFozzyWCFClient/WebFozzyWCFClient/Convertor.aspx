<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convertor.aspx.cs" Inherits="WebFozzyWCFClient.Convertor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Convertor</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 28px">
            <label for="Celsius">Celsius:</label>
            <br />
            <asp:TextBox ID="Celsius" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Calculate" runat="server" Text="Calculate" Height="29px" Width="108px" OnClick="Calculate_Click" />

            <br />
            <br />
            <label for="Fahrenheit">Fahrenheit:</label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="--Result--"></asp:Label>
        </div>
    </form>
</body>
</html>
