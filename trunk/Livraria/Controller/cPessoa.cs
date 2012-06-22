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
        private BaseDAL<Pessoa> DAL;

        public cPessoa(BaseDAL<Pessoa> DalPessoa)
        {
            this.DAL = DalPessoa;
        }


        public void salvarPessoa(Pessoa_Fisica pessoa)
        {
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