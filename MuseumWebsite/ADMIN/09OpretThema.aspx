<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/Admin.master" AutoEventWireup="true" CodeFile="09OpretThema.aspx.cs" Inherits="ADMIN_09OpretThema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlCreate" DefaultButton="btnMake" runat="server">
        <h2>Opret et Tema</h2>
        <div id="opret">
            <asp:Label ID="lblTitle" Text="Titel:" runat="server" required="true"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDesc" Text="Beskrivelse:" required="true" runat="server"></asp:Label>
            <asp:TextBox ID="txtDesc" TextMode="MultiLine" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblImg" Text="Image:" runat="server"></asp:Label>
            <asp:FileUpload ID="FuImg" runat="server" />
            <br />
            <br />

            <asp:Button ID="btnMake" Text="Tilføj Tema" runat="server" OnClick="btnMake_Click" />
        </div>
    </asp:Panel>
    <asp:Literal ID="litCreated" runat="server"></asp:Literal>

</asp:Content>

