<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Copy of CadastrarPessoa.aspx.cs" Inherits="Pessoa_CadastrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h1>Endereço</h1>
    <h4>Informações complementares:</h4>
    <br />
    Logradouro:&nbsp; 
    <asp:TextBox ID="TbLogradouro" runat="server" Width="281px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LbNumero" runat="server" Text="Número:  "></asp:Label>
    <asp:TextBox ID="TbNumero" runat="server" Width="85px"></asp:TextBox>
    <asp:Label ID="LbComplemento" runat="server" Text="Complemento:  "></asp:Label>
    <asp:TextBox ID="TbComplemento" runat="server" Width="116px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LbBairro" runat="server">Bairro:  </asp:Label>
    <asp:TextBox ID="TbBairro" runat="server" Width="212px"></asp:TextBox>
    <br />
    <br />
    Cidade:&nbsp; 
    <asp:TextBox ID="TbCidade" runat="server" Width="200px"></asp:TextBox>
    <asp:Label ID="LbUf" runat="server" Text="Uf:  "></asp:Label>
    <asp:TextBox ID="TbUf" runat="server" Width="45px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btCadastrar" runat="server" onclick="Button1_Click" 
        Text="Cadastrar" />
    </p>
</asp:Content>

