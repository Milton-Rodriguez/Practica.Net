<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PracticaNet.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Css/StyleLogin.css" rel="stylesheet" type="text/css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Container">
            <h1>Bienvenido</h1>
            <p>Ingrese Su Nombre de Usuario</p>
            <asp:TextBox ID="txtUser" runat="server" name="User" value="" class="textBox"/>
            <p>Ingrese Su Contraseña</p>
            <asp:TextBox ID="password" runat="server" name="Password" value="" class="textBox"/> <br />
            <asp:Button runat="server" name="Ingresar" ID="BtnIngresar" VALUE="INGRESAR" OnClick="btnIngresar_Click1"/>
            <asp:Label ID="error" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
