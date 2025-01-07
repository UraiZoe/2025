<%@ Page Title="Oldal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <h3>Zojé</h3>
        <address>
            My way or the highway.<br />
            GyÁ<br />
            <abbr title="Phone">P:</abbr>
            Telephone
        </address>

        <address>
        <asp:TextBox ID="textHost" runat="server"></asp:TextBox>
        <asp:TextBox ID="textPort" runat="server"></asp:TextBox>
        <asp:TextBox ID="textDatabase" runat="server"></asp:TextBox>
        <asp:TextBox ID="textUser" runat="server"></asp:TextBox>
        <asp:TextBox ID="textPass" runat="server"></asp:TextBox>


        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Esemeny"></asp:Button>
        <asp:GridView ID="dataGridView1" runat="server"></asp:GridView>

            <strong><a href="https://www.paypal.com/paypalme/MartinGamer2019">Supportáld Martint</a></strong><br />
           </address>
    </main>
</asp:Content>
