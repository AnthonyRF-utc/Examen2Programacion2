﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Exameen2Programacion2.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
    <h1>PAGINA DE EQUIPOS</h1>
</div>

      
   <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
         CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
         RowStyle-CssClass="rows" AllowPaging="True" />

     <br />
     <br />
     <br />

 
 <div class="container text-center">
     ID: <asp:TextBox ID="tIDequip" class="form-control" runat="server"></asp:TextBox>
     Tipo Equipo: <asp:TextBox ID="tTipEquip" class="form-control" runat="server"></asp:TextBox>
     Modelo: <asp:TextBox ID="tModelo" class="form-control" runat="server"></asp:TextBox>

 </div>
 <div class="container text-center">

     <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="Button1_Click" />
     <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" Text="Borrar" OnClick="Button2_Click" />
     <asp:Button ID="Button3" runat="server" class="btn btn-outline-danger" Text="Modificar" OnClick="Button3_Click" />
     <asp:Button ID="Bconsulta" runat="server" class="btn btn-outline-danger" Text="Consultar" OnClick="Bconsulta_Click" />
    </div>
</asp:Content>

