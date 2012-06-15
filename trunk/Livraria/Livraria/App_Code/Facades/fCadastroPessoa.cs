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
}