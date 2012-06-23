using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IPessoa
    {
        List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG);

        void salvar(Pessoa reg);

    }
}
