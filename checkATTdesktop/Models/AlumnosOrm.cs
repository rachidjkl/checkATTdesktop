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

        public static String Delete(Alumno alumno)
        {
            String missatge = "";
            Orm.bd.Alumno.Remove(alumno);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Update(Alumno alumno) {
            String missatge = "";
            Alumno _alumnoToEdit = Orm.bd.Alumno.Where(a => a.id_alumno == alumno.id_alumno).First();
            _alumnoToEdit.dni_alumno = alumno.dni_alumno;
            _alumnoToEdit.nombre_alumno = alumno.nombre_alumno;
            _alumnoToEdit.apellido1_alumno = alumno.apellido1_alumno;
            _alumnoToEdit.apellido2_alumno = alumno.apellido2_alumno;
            _alumnoToEdit.direccion_alumno = alumno.direccion_alumno;
            _alumnoToEdit.email_alumno = alumno.email_alumno;
            _alumnoToEdit.email_centro_alumno = alumno.email_centro_alumno;
            _alumnoToEdit.tel_alumno = alumno.tel_alumno;
            _alumnoToEdit.nacimiento_alumno = alumno.nacimiento_alumno;
            _alumnoToEdit.horas_cursadas_totales_alumno = alumno.horas_cursadas_totales_alumno;
            _alumnoToEdit.incorp_alumno = alumno.incorp_alumno;
            _alumnoToEdit.año_cursando_alumno = alumno.año_cursando_alumno;
            _alumnoToEdit.id_clase = alumno.id_clase;

            missatge = Orm.MySaveChanges();

            return missatge;
        }




    }
}
