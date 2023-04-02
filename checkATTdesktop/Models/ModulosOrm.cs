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

        public static int SelectModuloId(string nombreModulo, int horasTotales)
        {
            Modulo modulo = Orm.bd.Modulo.FirstOrDefault(u => u.nombre_modulo == nombreModulo && u.horas_totales_modulo == horasTotales);
            return modulo.id_modulo;
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
