using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{
    private fCadastroCliente cadastroClienteFacade = new fCadastroCliente();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        string nomeUsuario = RegisterUser.UserName;

        cadastroClienteFacade.RegistrarUsuario(nomeUsuario);

        Response.Redirect("Login.aspx");
    }

}
