using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

/// <summary>
/// Summary description for Class1
/// </summary>
public class fCadastroVendedor
{
    cUsuario myControler = new cUsuario();

    public void RegistrarUsuario(string nomeUsuario)
    {
        myControler.RegistrarVendedor(nomeUsuario);
    }
}