<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="07Login.aspx.cs" Inherits="_07Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlLogin" DefaultButton="btnLogin" runat="server">
        <div id="login">
            <p class="loginarea">Login:    </p>
            <asp:TextBox ID="txtUsername" required="true" runat="server"></asp:TextBox>
            <br />
            <p class="loginarea">Password:</p>
            <asp:TextBox ID="txtPassword" TextMode="Password" required="true" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
            <br />
            <asp:Literal ID="litResult" runat="server"></asp:Literal>

        </div>
    </asp:Panel>
</asp:Content>

