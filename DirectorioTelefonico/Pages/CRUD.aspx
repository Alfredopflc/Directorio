<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="DirectorioTelefonico.Pages.CRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    CRUD
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <br />
    <div class="mx-auto" style="width: 250px">
        <asp:Label runat="server" CssClass="h2" ID="lbltitulo"></asp:Label>
    </div>
    <form runat="server" class="h-100 d-flex align-items-center justify-content-center">
        <div>        
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="tbNombre"></asp:TextBox>
            </div>

            <div class="mb-3">
                <label class="form-label">Apellido</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="tbApe"></asp:TextBox>
            </div>

            <div class="mb-3">
                <label class="form-label">Telefono</label>
                <asp:TextBox runat="server" type= "number" CssClass="form-control" ID="tbTel"></asp:TextBox>
            </div>
        
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnCreate" Text="Create" Visible="false" OnClick="btnCreate_Click"/>
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnUpdate" Text="Update" Visible="false" OnClick="btnUpdate_Click"/>
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnDelete" Text="Delete" Visible="false" OnClick="btnDelete_Click"/>
            <asp:Button runat="server" CssClass="btn btn-primary btn-dark" ID="btnBack" Text="Volver" Visible="True" OnClick="btnBack_Click"/>
        </div>      
    </form>
</asp:Content>
