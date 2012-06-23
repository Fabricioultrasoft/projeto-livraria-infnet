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

        public List<Pessoa_Fisica> PesquisarPessoaFisica(string NomePessoa, string CPF, string RG)
        {
            List<Pessoa_Fisica> lista = (from P in ct.Pessoa.OfType<Pessoa_Fisica>() where
                                            (P.Nome == NomePessoa || NomePessoa == "") &&
                                            (P.CPF == CPF || CPF == "") &&
                                            (P.RG == RG || RG == "")
                                            select P).ToList<Pessoa_Fisica>();

            return lista;
        }

        public void salvar(Pessoa reg)
        {
            
            ct.Pessoa.AddObject(reg);

            ct.SaveChanges();
        }
    }
}
