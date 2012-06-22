<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CadastrarPessoa.aspx.cs" Inherits="Pessoa_CadastrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="ErroLabel" runat="server" ></asp:Label>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <h2>Cadastro de Pessoa</h2>

    <asp:Panel ID="TipoPessoaPanel" runat="server">
        <strong><span class="style1">Tipo de Pessoa: </span>
        <asp:RadioButtonList ID="TipoPessoaRadioButtonList" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Selected="True" Value="PF">Pessoa Física</asp:ListItem>
            <asp:ListItem Value="PJ">PessoaJuridica</asp:ListItem>
        </asp:RadioButtonList>
        </strong>

    </asp:Panel>

    <asp:Panel ID="PessoaFisicaPanel" runat="server" GroupingText="Identificação">
        <asp:Button ID="SalvarButton" runat="server" Text="Salvar" 
            onclick="SalvarButton_Click" style="height: 26px" />
        <table width="400px">
            <tr>
                <td nowrap="nowrap">
                    Nome:</td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="NomeTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NomeRequiredFieldValidator" runat="server" 
                        ControlToValidate="NomeTextBox" Display="Dynamic" 
                        ErrorMessage="O campo Nome é obrigatório.">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap">
                    CPF:</td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="CPFTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="CPFRequiredFieldValidator" runat="server" 
                        ControlToValidate="CPFTextBox" Display="Dynamic" 
                        ErrorMessage="O campo CPF é obrigatório.">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap">
                    RG:</td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="RGTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RGRequiredFieldValidator" runat="server" 
                        ControlToValidate="RGTextBox" Display="Dynamic" 
                        ErrorMessage="O campo RG é obrigatório.">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap">
                    Data de Nascimento:</td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="DataNascimentoTextBox" runat="server" Width="309px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DataNascimentoRequiredFieldValidator" 
                        runat="server" ControlToValidate="DataNascimentoTextBox" Display="Dynamic" 
                        ErrorMessage="O campo Data de Nascimento é obrigatório.">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="DataNascimentoCompareValidator" runat="server" 
                        ControlToValidate="DataNascimentoTextBox" Display="Dynamic" 
                        ErrorMessage="Valor inválido para Data de Nascimento " Type="Date">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td valign="top" nowrap="nowrap">
                    Observação:</td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ObservacaoTextBox" runat="server" Height="97px" 
                        TextMode="MultiLine" Width="309px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Endereco" runat="server" GroupingText="Lista de Endereço">
        &nbsp;<asp:GridView ID="EnderecoGridView" runat="server" 
    CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </asp:Panel>
    
</asp:Content>

