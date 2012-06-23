<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListarPessoa.aspx.cs" Inherits="Pessoa_ListarPessoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">

        .style1
        {
            font-size: medium;
        }
        .style2
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="ErroLabel" runat="server" ></asp:Label>
<h2>Pesquisa de Pessoa</h2>
    <asp:Panel ID="FiltroPessoaPanel" runat="server" GroupingText="Filtro">
        <strong>
            <span class="style1">Tipo de Pessoa: </span>
            <asp:RadioButtonList ID="TipoPessoaRadioButtonList" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="PF">Pessoa Física</asp:ListItem>
                <asp:ListItem Value="PJ">PessoaJuridica</asp:ListItem>
            </asp:RadioButtonList>
        </strong>
        <asp:Panel ID="PessoaFisicaPanel" runat="server">
            <table>
                <tr>
                    <td nowrap="nowrap">
                        Nome:</td>
                    <td nowrap="nowrap" colspan="3">
                        <asp:TextBox ID="NomeTextBox" runat="server" Width="98%"></asp:TextBox>
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
                    <td nowrap="nowrap" class="style2">
                        RG:</td>
                    <td nowrap="nowrap" class="style2">
                        <asp:TextBox ID="RGTextBox" runat="server" Width="309px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RGRequiredFieldValidator" runat="server" 
                            ControlToValidate="RGTextBox" Display="Dynamic" 
                            ErrorMessage="O campo RG é obrigatório.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" nowrap="nowrap" align="right">
                        <asp:Button ID="PesquisarButton" runat="server" Text="Pesquisar" 
                            onclick="PesquisarButton_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
    <asp:GridView ID="ListaPessoaGridView" runat="server" AutoGenerateColumns="False" 
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
</asp:Content>

