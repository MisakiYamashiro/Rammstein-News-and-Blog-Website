<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="Rewards-Main.aspx.cs" Inherits="RammProtocol.Rewards_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="color: #D3B782">Rewards</h1>
        <br />
        <div class="text-header">
            <h2>The Recognition</h2>
        </div>
        <h4>Since 1994, Rammstein surprised, amazed, but also convinced. Whether it's came from the public, from professionals, or just by the number of albums sold, the band has accumulated an impressive number of awards of all kinds.</h4>
        <br />
        <div class="text-header">
            <h2>Choose a kind of reward</h2>
        </div>
        <div class="southside">
            <asp:ImageButton ImageUrl="Assets/Imgs/Rewards/certifications.jpg" ID="imgbtn_cert" runat="server" OnClick="imgbtn_cert_Click" />
            <label>
                Since 1995 and the Du riechst so gut single, Rammstein has sold almost 20 million of CD and DVD around the world. <br />
                This section will show you the certifications related to the number of sales of each release.</label>
        </div>
        <div class="westside">
            <asp:ImageButton ImageUrl="Assets/Imgs/Rewards/awards.jpg" ID="imgbtn_award" runat="server" OnClick="imgbtn_award_Click" />
            <label>
                Since 1997, Rammstein was nominated for numerous awards, televised or not. <br />
                This section will introduce you to awards earned by Rammstein, and those for which the Germans were only nominees.</label>
        </div>
    </div>
</asp:Content>
