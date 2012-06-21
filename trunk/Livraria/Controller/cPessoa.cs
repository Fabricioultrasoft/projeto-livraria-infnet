using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Controller
{
    public class cPessoa:IPessoa
    {
        private IPessoa DAL;

        public cPessoa(IPessoa DalPessoa)
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
