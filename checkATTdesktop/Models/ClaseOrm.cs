using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ClaseOrm
    {
        public static List<Clase> Select()
        {
            List<Clase> _clase = Orm.bd.Clase.ToList(); 
            
            return _clase;
        }


        public static String Insert(Clase clase)
        {
            String missatge = "";
            Orm.bd.Clase.Add(clase);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(Clase clase)
        {
            String missatge = "";
            Orm.bd.Clase.Remove(clase);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Update(Clase clase)
        {
            String missatge = "";
            Clase _clase = Orm.bd.Clase.Where(a => a.id_clase == clase.id_clase).First();

            _clase.id_clase = clase.id_clase;
            _clase.id_tutor_clase = clase.id_tutor_clase;

            missatge = Orm.MySaveChanges();

            return missatge;
        }

    }
}
