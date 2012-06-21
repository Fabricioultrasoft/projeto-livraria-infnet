using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IPessoa
    {
        void salvaPessoa(Pessoa pessoa);
        void deletarPessoa(Pessoa pessoa);
        List<Pessoa> selectPessoa();
        void updatePessoa(Pessoa pessoa);
    }
}
