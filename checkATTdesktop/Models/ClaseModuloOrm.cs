using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class ClaseModuloOrm
    {

        public static String Insert(Clase_Modulo claseModulo)
        {
            String missatge = "";
            Orm.bd.Clase_Modulo.Add(claseModulo);

            missatge = Orm.MySaveChanges();

            return missatge;

        }
    }
}
