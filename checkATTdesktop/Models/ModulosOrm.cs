using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ModulosOrm
    {
        public static List<Modulo> Select()
        {
            List<Modulo> _modulo = Orm.bd.Modulo.ToList();

            return _modulo;
        }

        public static Modulo SelectUltimoModulo()
        {
            Modulo ultimoModulo = Orm.bd.Modulo.OrderByDescending(m => m.id_modulo).FirstOrDefault();
            return ultimoModulo;
        }

        public static String Insert(Modulo modulo)
        {
            String missatge = "";
            Orm.bd.Modulo.Add(modulo);

            missatge = Orm.MySaveChanges();

            return missatge;

        }
    }
}
