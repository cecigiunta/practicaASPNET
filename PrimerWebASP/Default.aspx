<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimerWebASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <%--Ese contenido, se va a alojar en el contenedor con id "MainContent", que esta en masterpage--%>
    <div>
        <%--abro llaves de C# para hacer un if dentro del HTML--%>
        <% if(user != "")
            { %>

            <h2>Ingresaste!</h2>
            <asp:Label ID="lblUser" runat="server" Text="text"></asp:Label>
            <%} 
            else { %> 

            <h1>Debes loguearte</h1>
            <a href="ejConMasterPage">Login</a>
            <%} %>
    </div>


</asp:Content>
