using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class UFsOrm
    {
        public static String Insert(UF uf)
        {
            String missatge = "";
            Orm.bd.UF.Add(uf);

            missatge = Orm.MySaveChanges();

            return missatge;

        }

        public static String Update(UF uf)
        {
            String missatge = "";
            UF _udToEdit = Orm.bd.UF.Where(a => a.id_uf == uf.id_uf).First();
            _udToEdit.nombre_uf = uf.nombre_uf;
            _udToEdit.horas_totales_uf = uf.horas_totales_uf;
             missatge = Orm.MySaveChanges();

            return missatge;
        }
    }
}
