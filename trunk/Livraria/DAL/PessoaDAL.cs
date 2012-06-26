using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL.Exceptions;

namespace DAL
{
    public class PessoaDAL : IPessoa
    {
        LivrariaDBEntities ct = new LivrariaDBEntities();

        public List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG)
        {
            List<Pessoa_Fisica> lista = (from P in ct.Pessoa.OfType<Pessoa_Fisica>() where
                                            (P.Nome.Contains(NomePessoa) || NomePessoa == "") &&
                                            (P.CPF.Contains(CPF) || CPF == "") &&
                                            (P.RG.Contains(RG) || RG == "")
                                            select P).ToList<Pessoa_Fisica>();

            return lista;
        }

        public Pessoa_Fisica ConsultarPessoaFisica(Guid UserId)
        {
            Pessoa_Fisica pessoa = (from P in ct.Pessoa.OfType<Pessoa_Fisica>() where P.UserId == UserId select P).SingleOrDefault();

            return pessoa;
        }

        public Pessoa_Juridica ConsultarPessoaJuridica(Guid UserId)
        {
            Pessoa_Juridica pessoa = (from P in ct.Pessoa.OfType<Pessoa_Juridica>() where P.UserId == UserId select P).SingleOrDefault();

            return pessoa;
        }

        public void Cadastrar(Pessoa_Fisica reg)
        {
            int count = (from P in ct.Pessoa.OfType<Pessoa_Fisica>()
                         where (P.Nome == reg.Nome) ||
                                (P.CPF == reg.CPF) ||
                                (P.RG == reg.RG)
                         select P).Count<Pessoa_Fisica>();

            if (count > 0)
            {
                throw new RegistroDuplicadoException();
            }

            ct.Pessoa.AddObject(reg);

            ct.SaveChanges();
        }

        public void Atualizar(Pessoa_Fisica reg)
        {
            Pessoa_Fisica pessoa = (from P in ct.Pessoa.OfType<Pessoa_Fisica>() where P.Id == reg.Id select P).SingleOrDefault<Pessoa_Fisica>();

            if (pessoa == null)
            {
                throw new RegistroNaoEncontradoException();
            }

            pessoa.Nome = reg.Nome;
            pessoa.CPF = reg.CPF;
            pessoa.RG = reg.RG;
            pessoa.DataNascimento = reg.DataNascimento;
            pessoa.Observacao = reg.Observacao;

            ct.SaveChanges();
        }

    }
}
