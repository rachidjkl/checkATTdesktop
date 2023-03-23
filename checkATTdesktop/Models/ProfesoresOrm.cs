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


    }
}
