using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using Controller.Exceptions;


namespace Controller
{
    public class cProduto
    {
        private IProduto DAL;

        public cProduto(IProduto DalProduto)
        {
            this.DAL = DalProduto;
        }

        public void salvarProduto(Produto produto)
        {
            int count = DAL.PesquisarProduto(produto.Nome).Count;

            if (count > 0)
            {
                throw new WarningException("Já existe um produto cadastrado com esse nome.");
            }

            DAL.salvar(produto);

            throw new InformationException("Registro salvo com sucesso!");
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
}
