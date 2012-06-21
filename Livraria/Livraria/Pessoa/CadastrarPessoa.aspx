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
<h2>Cadastro de Pessoa</h2>

    <asp:Panel ID="TipoPessoaPanel" runat="server">
        <strong><span class="style1">Tipo de Pessoa: </span>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Selected="True" Value="PF">Pessoa Física</asp:ListItem>
            <asp:ListItem Value="PJ">PessoaJuridica</asp:ListItem>
        </asp:RadioButtonList>
        </strong>

    </asp:Panel>

    <asp:Panel ID="PessoaFisicaPanel" runat="server" GroupingText="Identificação">
        <asp:Button ID="SalvarButton" runat="server" Text="Salvar" />
        <table width="400px">
            <tr>
                <td>
                    Nome:</td>
                <td>
                    <asp:TextBox ID="NomeTextBox" runat="server" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    CPF:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    RG:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox0" runat="server" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap">
                    Data de Nascimento:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox1" runat="server" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Observação:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox2" runat="server" Height="97px" 
                        TextMode="MultiLine" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    &nbsp;</td>
                <td align="right">
                    
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
<<<<<<< .mine
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

