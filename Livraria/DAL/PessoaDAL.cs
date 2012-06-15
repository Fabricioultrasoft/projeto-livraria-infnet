using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class PessoaDAL : IPessoa
    {
        LivrariaDBEntities ct = new LivrariaDBEntities();

        public void salvaNome(string nome)
        {
            //salva no banco
        }
    }
}
