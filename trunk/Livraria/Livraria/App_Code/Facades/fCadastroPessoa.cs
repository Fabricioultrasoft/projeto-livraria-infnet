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

    private cPessoa myControler;

	public fCadastroPessoa()
	{
		myControler = new cPessoa(new PessoaDAL());
	}

    public void salvaPessoa(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }

    public void deletarPessoa(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }

    public List<Pessoa> selectPessoa()
    {
        throw new NotImplementedException();
    }

    public void updatePessoa(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }
}