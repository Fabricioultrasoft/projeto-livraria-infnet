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
    <h1>
        Cadastro de Produto</h1>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification"
        ValidationGroup="RegisterUserValidationGroup" />
    <asp:Panel ID="Panel1" runat="server" GroupingText="Form">
        <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="NomeLabel" runat="server" Text="Nome: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NomeTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NomeValidator" runat="server" ControlToValidate="NomeTextBox"
                        CssClass="failureNotification" ErrorMessage="O campo NOME deve ser preenchido."
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="DescricaoLabel" runat="server" Text="Descricao: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="DescricaoTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DescricaoValidator" runat="server" ControlToValidate="DescricaoTextBox"
                        CssClass="failureNotification" ErrorMessage="O campo DESCRICAO deve ser preenchido."
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="ValorLabel" runat="server" Text="Valor: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ValorTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValorValidator" runat="server" ControlToValidate="ValorTextBox"
                        CssClass="failureNotification" ErrorMessage="O campo VALOR deve ser preenchido."
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="CadastrarProdutoButton" runat="server" CommandName="MoveNext" Text="Cadastrar"
            ValidationGroup="RegisterUserValidationGroup" OnClick="CadastrarProdutoButton_Click" />
    </asp:Panel>
</asp:Content>
