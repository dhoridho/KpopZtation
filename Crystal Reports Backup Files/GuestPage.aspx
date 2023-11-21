<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestPage.aspx.cs" Inherits="KpopZtation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KpopZtation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        </div>
        
        <!-- HIDDEN CONTENT (START) -->
        <div id="hiddenContent1" runat="server" style="display: none;">
            <div>
                <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label><br />
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Choose Gender" Value="" Disabled="true" Selected="true" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList>
            </div>

            <div>
                <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label><br />
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </div>
        </div>
        <!-- HIDDEN CONTENT (END) -->

        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </div>

        <br /><br />

        <div>
            <asp:Button ID="btnToggle" runat="server" Text="View Registration Form" OnClick="btnToggle_Click"/>
            <br /><br />
            <div id="hiddenContent2" runat="server" style="display: block;">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            </div>
            <div id="hiddenContent3" runat="server" style="display: none;">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
            </div>
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="" style="color: red;"></asp:Label>
        </div>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
