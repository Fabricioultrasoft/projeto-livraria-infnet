using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

/// <summary>
/// Summary description for fMaster
/// </summary>
public class fMaster
{
    private cUsuario myControler = new cUsuario();

    public bool IsVendedor()
    {
        return myControler.isVendedor();
    }

    public bool IsCliente()
    {
        return myControler.isCliente();
    }
}