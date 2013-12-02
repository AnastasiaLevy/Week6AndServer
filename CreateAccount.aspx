<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: large;
            color: #000066;
            margin-left: 19px;
        }

        .newStyle1 {
            border-style: ridge;
            border-width: medium;
        }

        .auto-style3 {
            height: 20px;
            width: 854px;
        }

        .newStyle2 {
            background-color: #99CCFF;
            border: medium inset #00FF00;
            height: 343px;
            width: 721px;
            margin-left: 136px;
        }

        .newStyle3 {
            background-color: #EBEBEB;
            width: 124px;
            height: 34px;
            margin-left: 2px;
            margin-top: 11px;
        }

        .newStyle4 {
            border: medium inset #00FF00;
            width: 403px;
            height: 406px;
            margin-left: 240px;
            margin-top: 66px;
            background-color: #EFF3FB;
        }

        .newStyle10 {
            border: medium inset #00FF00;
            height: 30px;
            width: 848px;
            text-align: center;
        }
        .auto-style4 {
            background-color: #EFF3FB;
        }
        .auto-style5 {}
    </style>
</head>
<body background="Images/blue.jpg" style="height: 579px; width: 853px;">
    <form id="form1" runat="server">
        <div class="auto-style3">
            <div class="newStyle10">
                Welcome to Psychology 2010
            </div>
            <div class="newStyle4">
                <br />
                <asp:TextBox ID="firstName" runat="server" CssClass="auto-style2" Height="20px" Width="165px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; First Name<br />
                <br />
                <asp:TextBox ID="lastName" runat="server" CssClass="auto-style2" Height="20px" Width="165px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; Last Name<br />
                &nbsp;
        <br />
                <asp:TextBox ID="UserName" runat="server" CssClass="auto-style2" Height="20px" Width="165px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; UserName<br />
                <br />
                <asp:TextBox ID="Password" runat="server" CssClass="auto-style2" Height="20px" Width="165px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; Password<br />
                <br />
                <asp:TextBox ID="Cpassword" runat="server" CssClass="auto-style2" Height="20px" Width="165px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; Confirm Password<br />
                <br />
                <asp:DropDownList ID="LabList" runat="server" CssClass="auto-style2" DataSourceID="Labs" DataTextField="Schedule" DataValueField="Id" Height="22px" Width="222px">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="36px" OnClick="Button1_Click" Text="Submit" Width="77px" />
&nbsp;<asp:ObjectDataSource ID="Labs" runat="server" SelectMethod="ReturnList" TypeName="BusinessLayer"></asp:ObjectDataSource>


                <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" CssClass="auto-style4" Font-Bold="True" Font-Names="MV Boli" ForeColor="#FF3300" OnTextChanged="TextBox1_TextChanged" Width="391px"></asp:TextBox>


            </div>
    </form>
</body>

</html>
