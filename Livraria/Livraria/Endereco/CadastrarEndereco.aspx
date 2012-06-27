<%@ Page Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="CadastrarEndereco.aspx.cs" Inherits="Endereco_Endereco" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h1>Endereço</h1>
    <h4>Informações complementares:</h4>
    <br />
    Logradouro:&nbsp; 
    <asp:TextBox ID="TbLogradouro" runat="server" Width="281px"></asp:TextBox>
    <br />
    <br />
      <asp:RequiredFieldValidator ID="NomeRequiredFieldValidator" runat="server" 
                        ControlToValidate="TbNumero" Display="Dynamic" 
                        ErrorMessage="O campo Numero é obrigatório.">*</asp:RequiredFieldValidator>
    <asp:Label ID="LbComplemento" runat="server" Text="Complemento:  "></asp:Label>
    <asp:TextBox ID="TbComplemento" runat="server" Width="265px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TbComplemento" Display="Dynamic" 
                        ErrorMessage="O campo Complemento é obrigatório.">*</asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="LbBairro" runat="server">Bairro:  </asp:Label>
    <asp:TextBox ID="TbBairro" runat="server" Width="319px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TbBairro" Display="Dynamic" 
                        ErrorMessage="O campo Complemento é obrigatório.">*</asp:RequiredFieldValidator>
    <br />
    <br />
    Cidade:&nbsp; 
    <asp:TextBox ID="TbCidade" runat="server" Width="200px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TbCidade" Display="Dynamic" 
                        ErrorMessage="O campo Complemento é obrigatório.">*</asp:RequiredFieldValidator>
    <asp:Label ID="LbUf" runat="server" Text="Uf:  "></asp:Label>
    <asp:TextBox ID="TbUf" runat="server" Width="45px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btCadastrar" runat="server" onclick="Button1_Click" 
        Text="Cadastrar" />
</asp:Content>