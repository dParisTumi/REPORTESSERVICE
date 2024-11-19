<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CursoForm.aspx.cs" Inherits="DEMO1.CursoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
         <div class="container">
            <asp:TextBox id="txtNombre" runat="server" placeHolder="Ingrese Nombre del cursp" CssClass="form-control"/>
            <asp:TextBox id="txtTipo" runat="server" placeHolder="Ingrese Tipo curso" CssClass="form-control"/>
             <asp:TextBox id="txtCiclo" runat="server" placeHolder="Ingrese ciclo" CssClass="form-control"/>
             <asp:TextBox id="txtCreditos" runat="server" placeHolder="Ingrese credito" CssClass="form-control"/>
            <asp:Button id="btnGuardar" Text="Guardar" runat="server" CssClass="btn btn-primary"/>
        </div>
    </main>
</asp:Content>
