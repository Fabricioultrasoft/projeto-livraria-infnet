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
    private cUsuarios myControler = new cUsuarios();

    public bool IsVendedor()
    {
        return myControler.isVendedor();
    }

    public bool IsCliente()
    {
        return myControler.isCliente();
    }
}