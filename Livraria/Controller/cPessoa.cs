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
        public void getEmail(string email)
        {
            DAL.salvaEmail(email);
        }
        public void getUsuario(string usuario)
        {
            DAL.salvaUsuario(usuario);
        }
        public void getSenha(string senha)
        {
            DAL.salvaSenha(senha);
        }
        public void getLogradouro(string logradouro)
        {
            DAL.salvaLogradouro(logradouro);
        }
        public void getNumLograd(string numeroLograd)
        {
            DAL.salvaNumLograd(numeroLograd);
        }
        public void getComplementoLograd(string complementoLograd)
        {
            DAL.salvaComplementoLograd(complementoLograd);
        }
        public void getBairro (string bairro)
        {
            DAL.salvaBairro(bairro);
        }
        public void getCidade(string cidade)
        {
            DAL.salvaCidade(cidade);
        }
        public void getUf(string uf)
        {
            DAL.salvaUf(uf);
        }
        
    }
}
