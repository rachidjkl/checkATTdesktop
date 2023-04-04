using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class UFsOrm
    {

        public static UF SelectUf(int idModulo, string nombreUf)
        {
            try
            {
                UF _uf = Orm.bd.UF.Where(a => a.id_modulo_uf == idModulo && a.nombre_uf == nombreUf).First();
                return _uf;
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public static String Insert(UF uf)
        {
            String missatge = "";
            Orm.bd.UF.Add(uf);

            missatge = Orm.MySaveChanges();

            return missatge;

        }

        public static String Update(UF uf)
        {
            String missatge = "";
            try
            {
                UF _udToEdit = Orm.bd.UF.Where(a => a.id_uf == uf.id_uf).First();
                _udToEdit.nombre_uf = uf.nombre_uf;
                _udToEdit.horas_totales_uf = uf.horas_totales_uf;
                missatge = Orm.MySaveChanges();
            }
            catch (InvalidOperationException ex)
            {
               
            }

            return missatge;
        }


        public static List<UF> Select(int idModuloUf)
        {
            List<UF> _ufs = Orm.bd.UF.Where(a => a.id_modulo_uf == idModuloUf).ToList();

            return _ufs;
        }

        public static String Delete(int idModulo, string nombreUf)
        {
            String missatge = "";
            try
            {
                Orm.bd.UF.Remove(Orm.bd.UF.Where(a => a.id_modulo_uf == idModulo && a.nombre_uf == nombreUf).First());
                missatge = Orm.MySaveChanges();
            }
            catch (InvalidOperationException ex)
            {
               
            }

            return missatge;
        }

    }
}
