using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Controller.Exceptions;

public partial class Pessoa_CadastrarUsuario : System.Web.UI.Page
{
    private fCadastroPessoa CadadastroPessoaFacade = new fCadastroPessoa();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SalvarButton_Click(object sender, EventArgs e)
    {
        try
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
        catch (InformationException ex)
        {
            ErroLabel.CssClass = "information";
            ErroLabel.Text = ex.Message;
        }
        catch (WarningException ex)
        {
            ErroLabel.CssClass = "warning";
            ErroLabel.Text = ex.Message;
        }
        catch (Exception ex)
        {
            ErroLabel.CssClass = "Error";
            ErroLabel.Text = ex.Message;
        }
    }
}