<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DEMO1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
      <div class="container">
         <asp:TextBox id="txtNombres" runat="server" placeHolder="Ingrese Nombres" CssClass="form-control"/>
         <asp:TextBox id="txtApellidos" runat="server" placeHolder="Ingrese Apellidos" CssClass="form-control"/>
         <asp:Button id="btnGuardar" Text="Guardar" runat="server" CssClass="btn btn-primary"/>
     </div>
    </main>
</asp:Content>
