<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListarVendedor.aspx.cs" Inherits="Vendedor_ListarVendedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Lista de Vendedores</h2>
    <asp:Panel ID="NovoCadastroPanel" runat="server" HorizontalAlign="Right">
        <asp:HyperLink ID="NovoCadastroHyperLink" runat="server" 
            EnableViewState="False" NavigateUrl="CadastrarVendedor.aspx">Criar Nova Conta</asp:HyperLink>
    </asp:Panel>
    <div>
        <asp:GridView ID="ListaVendedoresGridView" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="UserName" 
            onrowdeleting="ListaVendedoresGridView_RowDeleting" Width="100%" >
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:TemplateField HeaderText="Excluir" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                            CommandName="Delete" Text="Excluir" OnClientClick="confirm('Tem certeza que deseja excluir o registro?);" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

