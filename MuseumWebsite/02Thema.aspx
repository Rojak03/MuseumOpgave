<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="02Thema.aspx.cs" Inherits="_02Thema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="katorgiList">
        <ul>
            <asp:Literal ID="litKategorier" runat="server"></asp:Literal>
        </ul>
    </div>
    <asp:Literal ID="litThemaResult" runat="server"></asp:Literal>
</asp:Content>

