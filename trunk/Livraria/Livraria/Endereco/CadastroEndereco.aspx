<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="CadastroEndereco.aspx.cs" Inherits="Endereco_CadastroEndereco" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h1>Endereço</h1>
    <h4>Informações complementares:</h4>
    <br />
    Logradouro:&nbsp; 
    <asp:TextBox ID="LogradouroTextBox" runat="server" Width="281px" 
        style="margin-left: 0px"></asp:TextBox>
    <br />
      <asp:RequiredFieldValidator ID="NomeRequiredFieldValidator" runat="server" 
                        ControlToValidate="TbNumero" Display="Dynamic" 
                        ErrorMessage="O campo Numero é obrigatório.">*</asp:RequiredFieldValidator>
    <asp:Label ID="LbComplemento" runat="server" Text="Complemento:  "></asp:Label>
    <asp:TextBox ID="ComplementoTextBox" runat="server" Width="265px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="ComplementoTextBox" Display="Dynamic" 
                        ErrorMessage="O campo Complemento é obrigatório.">*</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LbBairro" runat="server">Bairro:  </asp:Label>
    <asp:TextBox ID="BairroTextBox" runat="server" Width="319px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="BairroTextBox" Display="Dynamic" 
                        ErrorMessage="O campo Bairro é obrigatório.">*</asp:RequiredFieldValidator>
    <br />
    Cidade:&nbsp; 
    <asp:TextBox ID="CidadeTextBox" runat="server" Width="200px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="CidadeTextBox" Display="Dynamic" 
                        ErrorMessage="O campo Cidade é obrigatório.">*</asp:RequiredFieldValidator>
    <asp:Label ID="LbUf" runat="server" Text="Uf:  "></asp:Label>
    <asp:TextBox ID="UfTextBox" runat="server" Width="45px"></asp:TextBox>
    <br />
    <asp:Button ID="btCadastrar" runat="server" onclick="Button1_Click" 
        Text="Cadastrar" />
</asp:Content>