using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using Model;
using DAL.Exceptions;
using Controller.Exceptions;

namespace Controller
{
    
        public class cEndereco
        {
            
            public static Guid getCurrentUserId()
            {
                MembershipUser user = Membership.GetUser();

                return (Guid)user.ProviderUserKey;

            }


            public void SalvarEndereco(Endereco endereco)
            {
                if (endereco.Id == 0)
                {
                    try
                    {
                        DAL.Cadastrar(endereco);
                    }
                    catch (RegistroDuplicadoException)
                    {
                        throw new WarningException("Já existe um endereco cadastrada com esses dados.");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        DAL.Atualizar(endereco);
                    }
                    catch (RegistroNaoEncontradoException)
                    {
                        throw new Exception("Ocorreu um erro na alteração do endereco.");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

                throw new InformationException("Registro salvo com sucesso!");
            }




            public Pessoa ObterEndereco(Guid guid)
            {
                throw new NotImplementedException();
            }
        }
    

}
