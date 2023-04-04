using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class Clase_moduloOrm
    {
        public static List<Clase_Modulo> Select()
        {
            List<Clase_Modulo> _Clase_Modulo = Orm.bd.Clase_Modulo.ToList();

            return _Clase_Modulo;
        }
    }
}
