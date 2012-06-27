using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controller;
using DAL;
using Model;

public class fCadastroProduto
{
    private cProduto ProdutoControler;

    public fCadastroProduto()
    {
        ProdutoControler = new cProduto(new ProdutoDAL());
    }

    public void salvarProduto(Produto produto)
    {
        ProdutoControler.salvarProduto(produto);
    }

    public void deletarProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

    public void updateProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

}
