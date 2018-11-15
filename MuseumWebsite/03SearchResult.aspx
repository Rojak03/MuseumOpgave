<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="03SearchResult.aspx.cs" Inherits="_03SearchResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <a id="Tilbage" href="01Default.aspx">BACK</a>
    <p id="søg">
        Du har søgt for:
        <span class="søgt">
            <asp:Literal ID="litSearched" runat="server" />
        </span>
    </p>

    <br />
    <div id="result">
        <asp:Literal ID="litResult" runat="server"></asp:Literal>
    </div>
</asp:Content>

