using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class AlumnosOrm
    {
        public static List<Alumno> Select(String id_clase)
        {
            List<Alumno> _alumno = Orm.bd.Alumno
                            .Where(c => c.id_clase == id_clase).ToList();
            return _alumno;
        }


        public static String Insert(Alumno alumno) {
            String missatge = "";
            Orm.bd.Alumno.Add(alumno);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(Alumno alumno)
        {
            String missatge = "";
            Orm.bd.Alumno.Remove(alumno);

            missatge = Orm.MySaveChanges();

            return missatge;
        }




    }
}
