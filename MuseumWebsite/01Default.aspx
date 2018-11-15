<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="01Default.aspx.cs" Inherits="_01Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <link href="CSS/jquery.bxslider.css" rel="stylesheet" />
    <script src="JS/jquery.bxslider.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ul class="bxslider">

        <li>
            <img id="lillebolig" src="Img/lilleboligslider.png" alt="Alternate Text" /></li>
        <li>
            <img id="aarhus" src="Img/aarhussilder.jpg" alt="Aarhus Mappe" /></li>
        <li>
            <img id="dagligliv" src="Img/galsilder.jpg" alt="Galleri example" /></li>
        <li>
            <img id="runesten" src="Img/boligslider.png" alt="A viking house" /></li>
        <li>
            <img src="Img/pottesilder.JPG" alt="Potte" /></li>
        <li>
            <img id="" src="Img/stenslider.JPG" alt="Stone with runes" /></li>
        <li>
            <img id="" src="Img/vikingslider.JPG" alt="Vikings" /></li>
        <li>
            <img id="" src="Img/tresilder.jpg" alt="stuff with wood" /></li>
    </ul>

    <div id="randomThemas">
        <asp:Literal ID="litRandom" runat="server"></asp:Literal>
    </div>

    <script src="JS/Slider.js"></script>
</asp:Content>

