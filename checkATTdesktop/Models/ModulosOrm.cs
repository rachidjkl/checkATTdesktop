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
    }
}
