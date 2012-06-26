using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IPessoa
    {
        List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG);

        void Cadastrar(Pessoa_Fisica reg);

        void Atualizar(Pessoa_Fisica reg);

        Pessoa_Fisica ConsultarPessoaFisica(Guid UserId);

        Pessoa_Juridica ConsultarPessoaJuridica(Guid UserId);
    }
}
