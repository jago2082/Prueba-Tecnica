<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prueba_Tecnica._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="row">
        <div class="form-group row">
            <asp:Label ID="Label1" runat="server" Text="Bucar"></asp:Label>
            <asp:TextBox ID="txtCriterio" runat="server" type="number"  placeholder="numero de documento"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="form-group row">
            <asp:Label ID="lblTipooc" runat="server" Text="Tipodocumento"></asp:Label>
            <asp:TextBox ID="txtTipodoc" runat="server" ></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label ID="lblNumero" runat="server" Text="Numero"></asp:Label>
            <asp:TextBox ID="txtNumDoc" runat="server" ></asp:TextBox>
        </div>
    </div>
</asp:Content>
