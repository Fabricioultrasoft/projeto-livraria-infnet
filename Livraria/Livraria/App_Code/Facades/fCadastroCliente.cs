using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

/// <summary>
/// Summary description for fCadastroCliente
/// </summary>
public class fCadastroCliente
{
    private cUsuario myControler = new cUsuario();

    public void RegistrarUsuario(string nomeUsuario)
    {
        myControler.RegistrarCliente(nomeUsuario);
    }
}