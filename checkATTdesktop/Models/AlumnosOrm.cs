using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class AlumnosOrm
    {
        public static List<Alumno> Select(String dni_alumno)
        {
            List<Alumno> _alumno = Orm.bd.Alumno
                            .Where(c => c.dni_alumno == dni_alumno).ToList();
            return _alumno;
        }


        public static String Insert(Alumno alumno) {
            String missatge = "";
            Orm.bd.Alumno.Add(alumno);

            missatge = Orm.MySaveChanges();

            return missatge;
        }


    }
}
