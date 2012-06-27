using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Controller;

/// <summary>
/// Summary description for Class1
/// </summary>
public class fCadastroEndereco
{

    private cEndereco EnderecoControler;

    public fCadastroEndereco()
    {
        EnderecoControler = new cEndereco(new EnderecoDAL());
    }

    public void salvarPessoa(Endereco endereco)
    {
        endereco.UserId = cUsuario.getCurrentUserId();

        EnderecoControler.SalvarEndereco(endereco);
    }

    public Pessoa ObterPessoa()
    {
        return EnderecoControler.ObterEndereco(cUsuario.getCurrentUserId());
    }

}