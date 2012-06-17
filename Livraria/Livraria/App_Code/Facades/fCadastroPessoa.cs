using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;
using DAL;

/// <summary>
/// Summary description for cCadastroPessoa
/// </summary>
public class fCadastroPessoa
{

    private cPessoa myControler;

	public fCadastroPessoa()
	{
		myControler = new cPessoa(new PessoaDAL());
	}

    public void getNomePessoa(string nome)
    {
        myControler.getNome(nome);
    }
    public void getEmail(string email)
    {
        myControler.getEmail(email);
    }
    public void getUsuario (string usuario)
    {
        myControler.getUsuario(usuario);
    }
    public void getSenha(string senha)
    {
        myControler.getSenha(senha);
    }
    public void getLogradouro(string logradouro)
    {
        myControler.getLogradouro(logradouro);
    }
    public void getNumLograd(string numeroLograd)
    {
        myControler.getNumLograd(numeroLograd);
    }
    public void getComplementoLograd(string complementoLograd)
    {
        myControler.getComplementoLograd(complementoLograd);
    }
    public void getBairro(string bairro)
    {
        myControler.getBairro(bairro);
    }
    public void getCidade(string cidade)
    {
        myControler.getCidade(cidade);
    }
    public void getUf(string uf)
    {
        myControler.getUf(uf);
    }

}