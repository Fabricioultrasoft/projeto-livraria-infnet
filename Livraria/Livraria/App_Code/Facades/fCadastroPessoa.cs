using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;
using DAL;
using Model;

/// <summary>
/// Summary description for cCadastroPessoa
/// </summary>
public class fCadastroPessoa
{

    private cPessoa PessoaControler;

	public fCadastroPessoa()
	{
		PessoaControler = new cPessoa(new PessoaDAL());
	}

    public void salvarPessoa(Pessoa_Fisica pessoa)
    {
        pessoa.UserId = cUsuario.getCurrentUserId();

        PessoaControler.SalvarPessoa(pessoa);
    }

    public Pessoa ObterPessoa()
    {
        return PessoaControler.ObterPessoa(cUsuario.getCurrentUserId());
    }

}