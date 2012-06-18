using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

public class fListarVendedor
{
    cUsuario myControler = new cUsuario();

	public object Listar()
	{
        return myControler.ListarVendedores();
	}

    public void ExcluirVendedor(string nomeUsuario)
    {
        myControler.Excluir(nomeUsuario);
    }
}