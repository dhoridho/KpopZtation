<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="KpopZtation.View.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Home Page</h1>
    </div>
    <div>
        <table border="1">
            <tr>
                <th>Artist ID</th>
                <th>Artist Name</th>
                <th>Artist Picture</th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
            <% foreach (var artst in Artists)
                {%>

            <tr>
                <td><% Response.Write(artst.ArtistID); %></td>
                <td><%=(artst.ArtistName) %></td>
                <td>
                    <img src="../../asset/<%=artst.ArtistImage%>" width="100" height="100"/></td>
                <td> <a href="AdminHomeUpdate.aspx?id=<%=artst.ArtistID %>">Update</a> </td>
            </tr>

            <%} %>
        </table>
    </div>
    <div>

    </div>
</asp:Content>
