using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace Controller
{
    public class cUsuarios
    {
        public bool isVendedor()
        {
            return Roles.IsUserInRole("Vendedor");
        }

        public bool isCliente()
        {
            return Roles.IsUserInRole("Cliente");
        }
    }
}
