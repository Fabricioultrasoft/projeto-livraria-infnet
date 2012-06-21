using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class Pessoa_CadastrarUsuario : System.Web.UI.Page
{
    private fCadastroPessoa CadadastroPessoaFacade = new fCadastroPessoa();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SalvarButton_Click(object sender, EventArgs e)
    {
        string tipoPessoa = TipoPessoaRadioButtonList.SelectedValue;

        switch (tipoPessoa)
        {
            case "PF":

                Pessoa_Fisica pf = new Pessoa_Fisica();

                pf.Nome = NomeTextBox.Text;
                pf.CPF = CPFTextBox.Text;
                pf.RG = RGTextBox.Text;
                pf.DataNascimento = DateTime.Parse(DataNascimentoTextBox.Text);
                pf.Observacao = ObservacaoTextBox.Text;

                CadadastroPessoaFacade.salvarPessoa(pf);

                break;
            case "PJ":
                break;
            default:
                break;
        }
    }
}