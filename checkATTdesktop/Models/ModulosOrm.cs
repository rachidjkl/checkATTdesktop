using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ModulosOrm
    {
        public static List<Modulo> SelectAll()
        {
            List<Modulo> _modulo = Orm.bd.Modulo.ToList();

            return _modulo;
        }

        public static List<Modulo> Select(int modulosClase)
        {
            List<Modulo> _modulo = Orm.bd.Modulo
                           .Where(c => c.id_modulo == modulosClase).ToList();
            return _modulo;
        }
    }
}
