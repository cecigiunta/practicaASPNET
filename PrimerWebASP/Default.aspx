<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimerWebASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <%--Ese contenido, se va a alojar en el contenedor con id "MainContent", que esta en masterpage--%>
    <div class="jumbotron">
        <h1>Hola !</h1>
        <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
        <p class="lead">ingresaste a la página!</p>
    </div>


</asp:Content>
