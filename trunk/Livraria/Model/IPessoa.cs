using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IPessoa
    {
        void salvaNome(string nome);
        void salvaEmail(string email);
        void salvaUsuario(string usuario);
        void salvaSenha(string senha);
        void salvaLogradouro(string logradouro);
        void salvaNumLograd(string numeroLograd);
        void salvaComplementoLograd(string complementoLograd);
        void salvaBairro(string bairro);
        void salvaCidade(string cidade);
        void salvaUf(string uf);


    }
}
