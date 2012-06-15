using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pessoa_CadastrarUsuario : System.Web.UI.Page
{
    private fCadastroPessoa CadadastroPessoaFacade = new fCadastroPessoa();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nomePessoa = TextBox1.Text;
        CadadastroPessoaFacade.getNomePessoa(nomePessoa);
    }
}