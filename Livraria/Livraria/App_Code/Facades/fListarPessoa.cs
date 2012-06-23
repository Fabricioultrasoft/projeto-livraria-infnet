using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;
using DAL;
using Model;

/// <summary>
/// Summary description for fListarPessoa
/// </summary>
public class fListarPessoa
{
    private cPessoa PessoaControler;

    public fListarPessoa()
    {
        PessoaControler = new cPessoa(new PessoaDAL());
    }

    public List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG)
    {
        return PessoaControler.PesquisarPessoaFisica(NomePessoa, CPF, RG);
    }


}