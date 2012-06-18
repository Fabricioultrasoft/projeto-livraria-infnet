using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace Controller
{
    public class cUsuario
    {
        private string roleVendedor = "Vendedor";
        private string roleCliente = "Cliente";

        public bool isVendedor()
        {
            return Roles.IsUserInRole(roleVendedor);
        }

        public bool isVendedor(string nomeUsuario)
        {
            return Roles.IsUserInRole(nomeUsuario, roleVendedor);
        }

        public bool isCliente()
        {
            return Roles.IsUserInRole(roleCliente);
        }
        
        public bool isCliente(string nomeUsuario)
        {
            return Roles.IsUserInRole(nomeUsuario, roleCliente);
        }

        public object ListarVendedores()
        {
            string[] vendedores = Roles.GetUsersInRole(roleVendedor);

            List<MembershipUser> ListaUsuarios = new List<MembershipUser>();

            foreach (var item in vendedores)
	        {

                MembershipUser u = Membership.GetUser(item);

                ListaUsuarios.Add(u);

	        }

            return (from U in ListaUsuarios select new { U.UserName, U.Email }).AsEnumerable(); 
        }

        public void Excluir(string nomeUsuario)
        {
            Membership.DeleteUser(nomeUsuario);
        }

        public void RegistrarVendedor(string nomeUsuario)
        {
            Roles.AddUserToRole(nomeUsuario, roleVendedor);
        }

        public void RegistrarCliente(string nomeUsuario)
        {
            Roles.AddUserToRole(nomeUsuario, roleCliente);
        }

    }
}
