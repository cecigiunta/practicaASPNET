﻿<%@ Page Title="EJEMPLO CON MASTER" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejConMasterPage.aspx.cs" Inherits="PrimerWebASP.ejConMasterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--Para que se muestre en mi master, el ID del ContentPlaceHolderID es el mismo que el id de la etiqueta
    contentplaceholder de la master--%>
    <%--En el HTML me aparece l4a tool box con controles, los arrastro--%>

    <h1>Ejemplo con MASTER</h1>    

    <%--Le activo el autopostback para que el TextChanged se haga en el momento--%>
    <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="textChanged"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Saludar" OnClick="saludar" /> 
    <%--Al elegirle OnClick y clickear la lista, se crea un evento automaticamente en el cs--%>

    <asp:Label ID="LabelSaludo" runat="server" Text=""></asp:Label>


    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
   

    <%--Para navegar entre paginas haciendo click en el link--%>
    <a href="About">Regresar</a>

</asp:Content>
