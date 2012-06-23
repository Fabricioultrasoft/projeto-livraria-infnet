using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
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

        public void salvarPessoa(Pessoa_Fisica pessoa)
        {
            int count = DAL.PesquisarPessoaFisica(pessoa.Nome, pessoa.CPF, pessoa.RG).Count;

            if (count > 0)
            {
                throw new WarningException("Já existe uma pessoa cadastrada com esses dados.");
            }

            DAL.salvar(pessoa);

            throw new InformationException("Registro salvo com sucesso!");
        }

        public void deletarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> selectPessoa()
        {
            throw new NotImplementedException();
        }

        public void updatePessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

    }
}