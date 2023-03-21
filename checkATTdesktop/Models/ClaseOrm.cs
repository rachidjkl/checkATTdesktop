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
    }
}
