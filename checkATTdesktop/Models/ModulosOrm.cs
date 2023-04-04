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

        public static List<Modulo> SelectPers(int id_clase)
        {
            var resultadoJoin = from modulo in Orm.bd.Modulo
                                join claseModulo in Orm.bd.Clase_Modulo
                                on modulo.id_modulo equals claseModulo.id_modulo
                                join clase in Orm.bd.Clase
                                on claseModulo.id_clase1 equals clase.id_clase
                                where clase.id_clase == id_clase
                                select modulo;

            return resultadoJoin.ToList();
        }
    }
}
