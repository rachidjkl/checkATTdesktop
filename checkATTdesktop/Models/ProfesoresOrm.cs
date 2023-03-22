using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ProfesoresOrm
    {
        public static void Insert(Profesor profesor)
        {
            Orm.bd.Profesor.Add(profesor);
            Orm.bd.SaveChanges();
        }

        public static List<Profesor> Select()
        {
            List<Profesor> _profesor = Orm.bd.Profesor.ToList();
            return _profesor;
        }


    }
}
