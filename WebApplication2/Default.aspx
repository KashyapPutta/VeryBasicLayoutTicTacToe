<%@ Page Title="TIC TAC TOE" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>


        <asp:Button ID="Button1" runat="server" Text="1" BorderStyle="Groove" Font-Bold="True"  Width="59px" OnClick="Button1_Click" Height="31px" BackColor="White"  />

         <asp:Button ID="Button2" runat="server" Text="2" BorderStyle="Outset" Font-Bold="True" Width="66px" OnClick="Button2_Click" Height="32px" BackColor="White" />
        <asp:Button ID="Button3" runat="server" Text="3" BorderStyle="Double" Font-Bold="True" Width="57px" OnClick="Button3_Click" Height="31px" BackColor="White" />
       <br />
        <asp:Button ID="Button4" runat="server" Text="4" BorderStyle="Double" Font-Bold="True" Width="58px" OnClick="Button4_Click" BackColor="White" />
        <asp:Button ID="Button5" runat="server" Text="5" BorderStyle="Double" Font-Bold="True" Width="64px" OnClick="Button5_Click" BackColor="White" />
        <asp:Button ID="Button6" runat="server" Text="6" BorderStyle="Double" Font-Bold="True" Width="60px" OnClick="Button6_Click" BackColor="White" />
        <br />
        <asp:Button ID="Button7" runat="server" Text="7" BorderStyle="Double" Font-Bold="True" Width="59px" OnClick="Button7_Click" BackColor="White" />
        <asp:Button ID="Button8" runat="server" Text="8" BorderStyle="Double" Font-Bold="True" Width="63px" OnClick="Button8_Click" BackColor="White" />
        <asp:Button ID="Button9" runat="server" Text="9" BorderStyle="Double" Font-Bold="True" Width="61px" OnClick="Button9_Click" BackColor="White" />
      
    </p>
    </asp:Content>
