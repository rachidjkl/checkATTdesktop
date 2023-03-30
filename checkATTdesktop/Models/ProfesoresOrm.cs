using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ProfesoresOrm
    {
        public static String Insert(Profesor profesor)
        {
            String missatge = "";
            Orm.bd.Profesor.Add(profesor);

            missatge = Orm.MySaveChanges();

            return missatge;
          
        }


        public static String Delete(Profesor profesor)
        {
            String missatge = "";
            Orm.bd.Profesor.Remove(profesor);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static List<Profesor> Select()
        {
            List<Profesor> _profesor = Orm.bd.Profesor.ToList();
            return _profesor;
        }

        public static String Update(Profesor profesor)
        {
            String missatge = "";
            Profesor _profesorToEdit = Orm.bd.Profesor.Where(a => a.id_profe == profesor.id_profe).First();
            _profesorToEdit.dni_profe = profesor.dni_profe;
            _profesorToEdit.nombre_profe = profesor.nombre_profe;
            _profesorToEdit.apellido1_profe = profesor.apellido1_profe;
            _profesorToEdit.apellido2_profe = profesor.apellido2_profe;
            _profesorToEdit.direccion_profe = profesor.direccion_profe;
            _profesorToEdit.email_profe = profesor.email_profe;
            _profesorToEdit.email_centro_profe = profesor.email_centro_profe;
            _profesorToEdit.tel_profe = profesor.tel_profe;
            _profesorToEdit.nacimiento_profe = profesor.nacimiento_profe;
            _profesorToEdit.incorp_profe = profesor.incorp_profe;



            missatge = Orm.MySaveChanges();

            return missatge;
        }


    }
}
