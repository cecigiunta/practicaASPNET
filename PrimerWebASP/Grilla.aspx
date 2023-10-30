<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grilla.aspx.cs" Inherits="PrimerWebASP.Grilla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h5>Grilla de Autos</h5>
    <div class="row">
        <div class="col">

            <asp:GridView ID="dgvAutos" CssClass="table dark" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                </Columns>
            </asp:GridView>
            <a href="AutoForm.aspx">Agregar</a>
        </div>
    </div>


</asp:Content>
