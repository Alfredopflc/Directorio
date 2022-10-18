<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DirectorioTelefonico.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js"></script>
    <link href="CSS/Estilos.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class ="bg-light">
    <div class="wrapper">
        <div class ="formcontent">
            <form id="formulario_login" runat="server" autocomplete="off">
                <div class ="form-control">
                    <div class ="row">
                        <asp:Label class="h2" ID="lblBienvenida" runat="server" Text="Bienvenido(a) al Sistema"></asp:Label>

                    </div>

                    <div>
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label>
                        <asp:TextBox ID="tbUsuario" CssClass="form-control" runat="server" placeholder ="Nombre de Usuario"></asp:TextBox>
                    </div>

                    <div>
                        <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                        <asp:TextBox ID="tbPassword" CssClass="form-control" TextMode="Password" runat="server" placeholder ="Password"></asp:TextBox>
                    </div>
                    <hr />
                    <div class ="row">
                        <asp:Label runat ="server" ID="lblError"  style="color:red" ></asp:Label>
                    </div>
                    <br />
                    <div class ="row">
                        <asp:Button ID="btnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Ingresar" onClick ="btnIngresar_Click"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
