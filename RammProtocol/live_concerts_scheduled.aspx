<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="live_concerts_scheduled.aspx.cs" Inherits="RammProtocol.live_concerts_scheduled" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        img {
        }

        p {
            font-size: 20pt;
        }

            p b {
                color: #D3B782;
            }
            .nediyooo {
                text-align:center;
                padding:10px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Rammstein thank all the fans who attended their concerts during the last tour.
        <br />
        <br />

        <b>No date is scheduled for the moment</b> because Rammstein is taking a break until further notice. This does not mean that the group has no plans, but simply that a new tour is not planned for now.
    </p>
    <div class="nediyooo">
        <img src="Assets/Imgs/ramcon1.jpg" alt="Alternate Text" />
        <br />
        
        <br />
        <img src="Assets/Imgs/ramcon2.jpg" alt="Alternate Text" />
    </div>

</asp:Content>
