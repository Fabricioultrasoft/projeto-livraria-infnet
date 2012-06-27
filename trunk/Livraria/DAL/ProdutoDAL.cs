using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class ProdutoDAL : IProduto
    {
        LivrariaDBEntities ct = new LivrariaDBEntities();

        public List<Produto> PesquisarProduto(string NomeProduto)
        {
            List<Produto> lista = (from P in ct.Produto
                                         where
                                             (P.Nome == NomeProduto)
                                         select P).ToList<Produto>();

            return lista;
        }

        public void salvar(Produto reg)
        {
            throw new NotImplementedException();
        }
    }
}
