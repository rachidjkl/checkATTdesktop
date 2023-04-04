using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ClaseModuloOrm
    {

        public static List<Clase_Modulo> Select(int idModulo)
        {
            List<Clase_Modulo> _claseModulos = Orm.bd.Clase_Modulo.Where(a => a.id_modulo == idModulo).ToList();

            return _claseModulos;

        }

        public static Clase_Modulo SelectClaseModulo(int idModulo, int idClase)
        {
            try
            {
                Clase_Modulo _claseModulo = Orm.bd.Clase_Modulo.Where(a => a.id_modulo == idModulo && a.id_clase1 == idClase).First();
                return _claseModulo;
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }


        public static String Insert(Clase_Modulo claseModulo)
        {
            String missatge = "";
            Orm.bd.Clase_Modulo.Add(claseModulo);

            missatge = Orm.MySaveChanges();

            return missatge;

        }

        public static String Update(Clase_Modulo claseModulo)
        {
            String missatge = "";
            Clase_Modulo _clasemoduloToEdit = Orm.bd.Clase_Modulo.Where(a => a.id_clase_modulo == claseModulo.id_clase_modulo).First();
            _clasemoduloToEdit.id_clase1 = claseModulo.id_clase1;
            _clasemoduloToEdit.id_modulo = claseModulo.id_modulo;

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(int idClase, int idModulo)
        {
            String missatge = "";
            try
            {
                Orm.bd.Clase_Modulo.Remove(Orm.bd.Clase_Modulo.Where(a => a.id_modulo == idModulo && a.id_clase1 == idClase).First());
                missatge = Orm.MySaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                
            }

            return missatge;
        }

    }
}
