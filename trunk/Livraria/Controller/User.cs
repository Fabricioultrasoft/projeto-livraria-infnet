using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace Controller
{
    public class User
    {
        public bool isVendedor()
        {

            string roleName = Roles.GetRolesForUser()[0];


            return roleName.Equals("Vendedor");
        }
        
        public bool isCliente()
        {

            string roleName = Roles.GetRolesForUser()[0];


            return roleName.Equals("Cliente");
        }

    }
}
