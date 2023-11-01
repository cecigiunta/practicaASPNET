<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grilla.aspx.cs" Inherits="PrimerWebASP.Grilla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h5>Grilla de Autos</h5>
    <div class="row">
        <div class="col">

            <%--Le agrego a la grilla para que se genere un evento al seleccionar un item--%>
            <%--Con DataKeyName, le estoy diciendo a la grilla que va a haber un dato que es clave, en este caso el Id--%> 
            <asp:GridView ID="dgvAutos" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged" DataKeyNames="Id" CssClass="table dark" runat="server" AutoGenerateColumns="false">
                <Columns>                  

                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />


                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />

                         
                </Columns>
            </asp:GridView>
            <a href="AutoForm.aspx">Agregar</a>
        </div>
    </div>


</asp:Content>
