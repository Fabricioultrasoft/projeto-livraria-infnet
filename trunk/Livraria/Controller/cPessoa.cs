using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Controller
{
    public class cPessoa
    {
        private IPessoa DAL;

        public cPessoa(IPessoa DalPessoa)
        {
            this.DAL = DalPessoa;
        }

        public void getNome(string nome)
        {
            DAL.salvaNome(nome);
        }
    }
}
