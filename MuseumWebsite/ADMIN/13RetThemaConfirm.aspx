<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/Admin.master" AutoEventWireup="true" CodeFile="13RetThemaConfirm.aspx.cs" Inherits="ADMIN_13RetThemaConfirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlretThema" DefaultButton="btnConfirm" runat="server">
        <div id="RetBox">
            <h2>Ret, Bekræft</h2>
            <asp:Literal ID="litMessage" runat="server"></asp:Literal>
            <asp:Label ID="lblID" Text="ID:" Enabled="false" ReadOnly="true" runat="server"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTitle" Text="Titel:" required="true" runat="server"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDescription" Text="Beskrivelse:" required="true" runat="server"></asp:Label>
            <asp:TextBox ID="txtDesc" TextMode="Multiline" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Panel ID="pnlImage" runat="server">
                <asp:Label ID="lblCurrentimg" Text=" Nuværende billede:" runat="server"></asp:Label>
                <asp:Image ID="imgThema" runat="server" Width="100" />
                <br />
                <asp:Label ID="lblDel" Text="Slet:" runat="server"></asp:Label>
                <asp:CheckBox ID="chkDelImg" runat="server" />
            </asp:Panel>

            <br />
            <asp:Label ID="lblNewImg" Text="Vælg et nyt billede" runat="server"></asp:Label>
            <asp:FileUpload ID="fuImg" runat="server" Width="100" />
            <asp:Button ID="btnConfirm" Text="Bekræft?" runat="server" OnClick="btnConfirm_Click" />
        </div>
    </asp:Panel>
</asp:Content>

