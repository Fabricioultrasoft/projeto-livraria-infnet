<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="CadastrarProduto.aspx.cs" Inherits="Produto_CadastrarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Label ID="ErroLabel" runat="server"></asp:Label>
    <asp:ValidationSummary ID="ValidationSummary"  runat="server" />
    <h2>
        Cadastro de Produto</h2>
    <asp:Panel ID="ProdutoPanel" runat="server" GroupingText="Identificação">
        <asp:Button ID="CadastrarProdutoButton" runat="server" CommandName="MoveNext" Text="Salvar"
             OnClick="CadastrarProdutoButton_Click" />
        <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="NomeLabel" runat="server" Text="Nome: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NomeTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NomeRequiredFieldValidator" runat="server" ControlToValidate="NomeTextBox"
                        Display="Dynamic" ErrorMessage="O campo Nome é obrigatório." >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="DescricaoLabel" runat="server" Text="Descricao: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="DescricaoTextBox" runat="server" TextMode="MultiLine" Width="309px" Height="97px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DescricaoRequiredFieldValidator" runat="server" ControlToValidate="DescricaoTextBox"
                        Display="Dynamic" ErrorMessage="O campo Descrição é obrigatório." >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="ValorLabel" runat="server" Text="Valor: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ValorTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValorRequiredFieldValidator" runat="server" ControlToValidate="ValorTextBox"
                        Display="Dynamic" ErrorMessage="O campo Valor é obrigatório." >*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="ValorCompareValidator" runat="server" 
                        ControlToValidate="ValorTextBox" Display="Dynamic" 
                        ErrorMessage="Input inválido para Valor" Type="Double" >*</asp:CompareValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
