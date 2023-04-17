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

        public static int? SelectModuloId(string nombreModulo, int horasTotales)
        {
            try
            {
                Modulo modulo = Orm.bd.Modulo.FirstOrDefault(u => u.nombre_modulo == nombreModulo && u.horas_totales_modulo == horasTotales);
                return modulo.id_modulo;
            }
            catch (NullReferenceException ex)
            {
               
                return null;
            }
        }

        public static String Insert(Modulo modulo)
        {
            String missatge = "";
            Orm.bd.Modulo.Add(modulo);

            missatge = Orm.MySaveChanges();

            return missatge;

        }

        public static String Update(Modulo modulo)
        {
            String missatge = "";
            Modulo _moduloToEdit = Orm.bd.Modulo.Where(a => a.id_modulo == modulo.id_modulo).First();
            _moduloToEdit.nombre_modulo = modulo.nombre_modulo;
            _moduloToEdit.horas_totales_modulo = modulo.horas_totales_modulo;
            _moduloToEdit.siglas_uf = modulo.siglas_uf; 

            missatge = Orm.MySaveChanges();

            return missatge;
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
