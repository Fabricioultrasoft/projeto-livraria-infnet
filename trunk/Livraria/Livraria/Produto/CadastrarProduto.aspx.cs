using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Controller.Exceptions;

public partial class Produto_CadastrarProduto : System.Web.UI.Page
{
    private fCadastroProduto CadastroProdutoFacade = new fCadastroProduto();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CadastrarProdutoButton_Click(object sender, EventArgs e)
    {
        Produto novoProduto = new Produto();

        double valor_default_para_teste = 100;

        novoProduto.Nome = NomeTextBox.ToString();
        novoProduto.Descricao = DescricaoTextBox.ToString();
        novoProduto.Valor = valor_default_para_teste; //ValorTextBox.ToString();

        CadastroProdutoFacade.salvarProduto(novoProduto);
    }
}