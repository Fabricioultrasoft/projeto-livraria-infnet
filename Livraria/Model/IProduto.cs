using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IProduto
    {
        List<Produto> PesquisarProduto(string NomeProduto);

        void salvar(Produto reg);
    }
}
