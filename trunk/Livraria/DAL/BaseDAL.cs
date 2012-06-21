using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public abstract class BaseDAL<T>
    {
        protected LivrariaDBEntities ct = new LivrariaDBEntities();

        public abstract void salvar(T reg);

    }
}
