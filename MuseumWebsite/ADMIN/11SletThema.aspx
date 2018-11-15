<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/Admin.master" AutoEventWireup="true" CodeFile="11SletThema.aspx.cs" Inherits="ADMIN_11SletThema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>

        function ConfirmDel() {
            return confirm("Er du Sikkeret?");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlRetThema" runat="server">
        <div id="sletThema">
            <asp:Literal ID="litResult" runat="server"></asp:Literal>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnlRetKonferm" Visible="false" runat="server">

        <h2>Tema er slettet</h2>
        <asp:Literal ID="litMessage" runat="server"></asp:Literal>

        <p><a href="08AdminDeafult.aspx.aspx">Back</a></p>
    </asp:Panel>
</asp:Content>

