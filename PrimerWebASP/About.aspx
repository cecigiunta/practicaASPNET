<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PrimerWebASP.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <!-- el <% %> es una apertura y cierre indicando que se puede escribir codigo C#
        Title es una propertie de la clase Page
        -->


    <h3>Hola nueva app!</h3>
    
    <p>Use this area to provide additional information.</p>
</asp:Content>
