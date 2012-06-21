<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CadastrarPessoa.aspx.cs" Inherits="Pessoa_CadastrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h1>Cadastro de Pessoa</h1>
<p>
    <asp:Label ID="LbNome" runat="server" Text="Nome:  "></asp:Label>
    <asp:TextBox ID="tbNome" runat="server" Width="309px"></asp:TextBox>
        </p>
    <asp:Label ID="LbEmail" runat="server" Text="Email:   "></asp:Label>
    <asp:TextBox ID="TbEmail" runat="server" Width="310px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LbNomeUsuario" runat="server" Text="Nome de Usuário:  "></asp:Label>
    <asp:TextBox ID="TbNomeUsuario" runat="server" Width="179px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Senha:  "></asp:Label>
    <asp:TextBox ID="TbSenha" runat="server"></asp:TextBox>
    <h4>&nbsp;</h4>
    <br />
    <asp:Button ID="btCadastrar" runat="server" onclick="Button1_Click" 
        Text="Cadastrar" />
    <br />
    <br />
    <br />
    <br />
    <br />
    </p>
</asp:Content>

