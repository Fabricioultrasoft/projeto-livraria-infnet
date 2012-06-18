using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Vendedor_CadastrarVendedor : System.Web.UI.Page
{
    fCadastroVendedor cadastroVendedorFacade = new fCadastroVendedor();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        string nomeUsuario = RegisterUser.UserName;

        cadastroVendedorFacade.RegistrarUsuario(nomeUsuario);

        Response.Redirect("ListarVendedor.aspx");
    }
}