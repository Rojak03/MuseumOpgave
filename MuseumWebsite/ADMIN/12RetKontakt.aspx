<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/Admin.master" AutoEventWireup="true" CodeFile="12RetKontakt.aspx.cs" Inherits="ADMIN_RetKontakt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlKontakt" DefaultButton="btnConfirm" runat="server">

        <h2>Ret, Bekræft</h2>
        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
        <asp:Label ID="lblID" Text="ID:" Enabled="false" ReadOnly="true" runat="server"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" Text="Adresse:" runat="server"></asp:Label>
        <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblBy" Text="By:" runat="server"></asp:Label>
        <asp:TextBox ID="txtBy" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPost" Text="PostNr:" runat="server"></asp:Label>
        <asp:TextBox ID="txtPost" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" Text="E-mail:" runat="server"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTelephone" Text="Telefon:" runat="server"></asp:Label>
        <asp:TextBox ID="txttelephone" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnConfirm" Text="Bekræft?" runat="server" OnClick="btnConfirm_Click" />
    </asp:Panel>
</asp:Content>

