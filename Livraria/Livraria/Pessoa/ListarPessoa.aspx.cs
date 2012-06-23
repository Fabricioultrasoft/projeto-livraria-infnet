using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller.Exceptions;

public partial class Pessoa_ListarPessoa : System.Web.UI.Page
{
    fListarPessoa listarPessoaFacade = new fListarPessoa();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void PesquisarButton_Click(object sender, EventArgs e)
    {
        try
        {
            string tipoPessoa = TipoPessoaRadioButtonList.SelectedValue;
            
            switch (tipoPessoa)
            {
                case "PF":
                    
                    ListaPessoaGridView.DataSource = listarPessoaFacade.PesquisarPessoaFisica(
                                                        NomeTextBox.Text,
                                                        CPFTextBox.Text,
                                                        RGTextBox.Text);
                    ListaPessoaGridView.DataBind();

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