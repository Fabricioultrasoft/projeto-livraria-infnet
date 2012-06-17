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
        string nomePessoa = tbNome.Text;
        string email = TbEmail.Text;
        string usuario = TbNomeUsuario.Text;
        string senha = TbSenha.Text;
        string logradouro = TbLogradouro.Text;
        string numeroLograd = TbNumero.Text;
        string complementoLograd = TbComplemento.Text;
        string bairro = TbBairro.Text;
        string cidade = TbCidade.Text;
        string uf = TbUf.Text;


        CadadastroPessoaFacade.getNomePessoa(nomePessoa);
        CadadastroPessoaFacade.getEmail(email);
        CadadastroPessoaFacade.getUsuario(usuario);
        CadadastroPessoaFacade.getSenha(senha);
        CadadastroPessoaFacade.getLogradouro(logradouro);
        CadadastroPessoaFacade.getNumLograd(numeroLograd);
        CadadastroPessoaFacade.getComplementoLograd(complementoLograd);
        CadadastroPessoaFacade.getBairro(bairro);
        CadadastroPessoaFacade.getCidade(cidade);
        CadadastroPessoaFacade.getUf(uf);
    }
}