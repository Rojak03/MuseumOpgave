<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="06kontakt.aspx.cs" Inherits="_06kontakt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="Kontakt">
        <h2>Kontakt Os:</h2>
        <br />
        <h3>Address:</h3>
        <ul id="flyt">
            <li>
                <p>Vikingemuseet</p>
            </li>
            <asp:Literal ID="litAdress" runat="server"></asp:Literal>
        </ul>
        <div id="indgang">
            <img src="Img/indgang.jpg" alt="Indgang" /></div>
        <div id="map">
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1111.011819460178!2d10.210159462040712!3d56.15669589688177!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0000000000000000%3A0xe72c362de6b7bb8e!2sThe+Viking+Museum!5e0!3m2!1sen!2sdk!4v1459414999595" width="700" height="394" frameborder="0" style="border: 0" allowfullscreen></iframe>
        </div>
    </div>
</asp:Content>

