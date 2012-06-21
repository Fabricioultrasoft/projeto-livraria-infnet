using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class PessoaDAL : BaseDAL<Pessoa>
    {

        public override void salvar(Pessoa reg)
        {
            ct.Pessoa.AddObject(reg);

            ct.SaveChanges();
        }
    }
}
