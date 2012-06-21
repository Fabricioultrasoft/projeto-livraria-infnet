using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace Controller
{
    public class cPessoa
    {
        private BaseDAL<Pessoa> DAL;

        public cPessoa(BaseDAL<Pessoa> DalPessoa)
        {
            this.DAL = DalPessoa;
        }


        public void salvaPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
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
