<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminHomeUpdate.aspx.cs" Inherits="KpopZtation.View.Admin.AdminHomeUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblArtistID1" runat="server" Text="Artist ID : "></asp:Label>
        <asp:Label ID="lblArtistID" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblArtistName" runat="server" Text="Artist Name : "></asp:Label>
        <asp:TextBox ID="txtArtistName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblArtistImage" runat="server" Text="Artist Image : "></asp:Label>
        <asp:FileUpload ID="UploadImage" runat="server" />
    </div>
    <div>
        <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click"/>
    </div>
</asp:Content>
