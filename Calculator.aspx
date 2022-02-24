<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebCalculator.Calculator" %>

<!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Calculator</title>
        <link rel="stylesheet" href="css/style.css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <asp:TextBox ID="TextBox1" runat="server" class="textBox1" ReadOnly="True" ForeColor="#676767"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" class="textBox2" ReadOnly="True" ForeColor="White"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" class="btn btn_top" Text="CE" ForeColor="#676767" OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" class="btn" Text="C" ForeColor="#676767" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" class="btn" Text="⌫" ForeColor="#676767" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" class="btn" Text="÷" ForeColor="#676767" OnClick="Button4_Click" />
                <br />
                <asp:Button ID="Button5" runat="server" class="btn btn_between" Text="7" ForeColor="White" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" class="btn" Text="8" ForeColor="White" OnClick="Button6_Click" />
                <asp:Button ID="Button7" runat="server" class="btn" Text="9" ForeColor="White" OnClick="Button7_Click" />
                <asp:Button ID="Button8" runat="server" class="btn" Text="×" ForeColor="#676767" OnClick="Button8_Click" />
                <br />
                <asp:Button ID="Button9" runat="server" class="btn btn_between" Text="4" ForeColor="White" OnClick="Button9_Click" />
                <asp:Button ID="Button10" runat="server" class="btn" Text="5" ForeColor="White" OnClick="Button10_Click" />
                <asp:Button ID="Button11" runat="server" class="btn" Text="6" ForeColor="White" OnClick="Button11_Click" />
                <asp:Button ID="Button12" runat="server" class="btn" Text="-" ForeColor="#676767" OnClick="Button12_Click" />
                <br />
                <asp:Button ID="Button13" runat="server" class="btn btn_between" Text="1" ForeColor="White" OnClick="Button13_Click" />
                <asp:Button ID="Button14" runat="server" class="btn" Text="2" ForeColor="White" OnClick="Button14_Click" />
                <asp:Button ID="Button15" runat="server" class="btn" Text="3" ForeColor="White" OnClick="Button15_Click" />
                <asp:Button ID="Button16" runat="server" class="btn" Text="+" ForeColor="#676767" OnClick="Button16_Click" />
                <br />
                <asp:Button ID="Button17" runat="server" class="btn btn_between btn_zero" Text="0" ForeColor="White" OnClick="Button17_Click" />
                <asp:Button ID="Button18" runat="server" class="btn" Text="," ForeColor="White" OnClick="Button18_Click" />
                <asp:Button ID="Button19" runat="server" class="btn btn_equal" Text="=" ForeColor="White" OnClick="Button19_Click" />
            </div>
        </form>
    </body>
</html>
