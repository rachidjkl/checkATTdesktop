using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class MatriculaOrm
    {
        public static String Insert(Matricula matricula)
        {
            String missatge = "";
            Orm.bd.Matricula.Add(matricula);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

    }
}
