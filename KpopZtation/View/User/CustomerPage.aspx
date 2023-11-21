<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerPage.aspx.cs" Inherits="KpopZtation.View.User.CustomerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <p>
            <asp:Button ID="btnView" runat="server" Text="Display Profile Detail" OnClick="btnView_Click" />
            <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </p>

        <div id="hiddenContent1" runat="server" style="display: none;">
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button ID="btnViewUpdate" runat="server" Text="View Update Profile Form" OnClick="btnViewUpdate_Click" />

            <br /><br />
            <div id="hiddenContent2" runat="server" style="display: none;">
                <asp:Label ID="lblID" runat="server" Text="ID "></asp:Label>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblName" runat="server" Text="Name "></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblPassword" runat="server" Text="Password "></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />

                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label><br />
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Choose Gender" Value="" Disabled="true" Selected="true" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList><br />

                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>

                <asp:Label ID="lblEmailStatus" runat="server" Text="" style="color: red;"></asp:Label>

                <br />
                <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" />

            </div>
            <br />

            <h3>Artist</h3>
            <asp:GridView ID="GridViewArtist" runat="server"></asp:GridView>

            <br />
            <h3>Album</h3>
            <asp:GridView ID="GridViewAlbum" runat="server"></asp:GridView>

            <br />
            <%--<asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />--%>

        </div>

        <div>
            <p>Welcome <b><asp:Label ID="lblAfterLogin" runat="server" Text=""></asp:Label></b>!</p>
        </div>
    </form>
</body>
</html>
