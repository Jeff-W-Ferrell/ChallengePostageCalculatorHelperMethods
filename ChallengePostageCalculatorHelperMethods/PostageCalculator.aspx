<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostageCalculator.aspx.cs" Inherits="ChallengePostageCalculatorHelperMethods.PostageCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="masterTextBoxRadioControl"></asp:TextBox>
        <br />
        Height:
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="masterTextBoxRadioControl"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="masterTextBoxRadioControl"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="masterTextBoxRadioControl" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="masterTextBoxRadioControl" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="masterTextBoxRadioControl" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="calcLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
