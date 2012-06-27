using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class Endereco_CadastroEndereco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Endereco endereco = new Endereco();
        endereco.Bairro = BairroTextBox.Text;
        endereco.Cidade = CidadeTextBox.Text;
        endereco.Logradouro = LogradouroTextBox.Text;
        endereco.UF = UfTextBox.Text;
        endereco.Complemento = ComplementoTextBox.Text;


        endereco.UserId = cEndereco.getCurrentUserId();

       EnderecoControler.SalvarEndereco(endereco);

    }
}