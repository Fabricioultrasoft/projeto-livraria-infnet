using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using DAL.Exceptions;
using Controller.Exceptions;

namespace Controller
{
    public class cPessoa
    {
        private IPessoa DAL;

        public cPessoa(IPessoa DalPessoa)
        {
            this.DAL = DalPessoa;
        }

        public List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG)
        {
            return DAL.PesquisarPessoaFisica(NomePessoa, CPF, RG);
        }

        public void SalvarPessoa(Pessoa_Fisica pessoa)
        {
            if (pessoa.Id == 0)
            {
                try
                {
                    DAL.Cadastrar(pessoa);
                }
                catch(RegistroDuplicadoException)
                {
                    throw new WarningException("Já existe uma pessoa cadastrada com esses dados.");
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
                    DAL.Atualizar(pessoa);
                }
                catch (RegistroNaoEncontradoException)
                {
                    throw new Exception("Ocorreu um erro na alteração do perfil.");
                }
                catch (Exception)
                {
                    throw;
                }
            }

            throw new InformationException("Registro salvo com sucesso!");
        }

        public Pessoa ObterPessoa(Guid UserId)
        {
            Pessoa pessoa = DAL.ConsultarPessoaFisica(UserId);

            if (pessoa == null)
            {
                pessoa = DAL.ConsultarPessoaJuridica(UserId);
            }


            return pessoa;
        }
    }
}