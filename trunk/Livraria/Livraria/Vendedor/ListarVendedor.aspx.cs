using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vendedor_ListarVendedor : System.Web.UI.Page
{
    fListarVendedor listarVendedorFacade = new fListarVendedor();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListaVendedoresGridView.DataSource = listarVendedorFacade.Listar();
            ListaVendedoresGridView.DataBind();
        }
    }

    protected void ListaVendedoresGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int index = e.RowIndex;

        string nomeUsuario = ListaVendedoresGridView.DataKeys[index].Value.ToString();

        listarVendedorFacade.ExcluirVendedor(nomeUsuario);

        ListaVendedoresGridView.DataSource = listarVendedorFacade.Listar();
        ListaVendedoresGridView.DataBind();
    }
}