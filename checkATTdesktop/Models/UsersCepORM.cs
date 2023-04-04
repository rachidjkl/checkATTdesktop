using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class  UsersCepORM
    {
        public static String Insert(Usuarios_CEP user)
        {
            String missatge = "";
            Orm.bd.Usuarios_CEP.Add(user);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Update(Usuarios_CEP user)
        {
            String missatge = "";
            Usuarios_CEP userToEdit = Orm.bd.Usuarios_CEP.Where(a => a.id_usuario_cep == user.id_usuario_cep).First();
            userToEdit.correo_cep = user.correo_cep;
            userToEdit.contra = user.contra;
            
            missatge = Orm.MySaveChanges();

            return missatge;
        }


        public static int SelectUserCepId(string email)
        {
            Usuarios_CEP modulo = Orm.bd.Usuarios_CEP.FirstOrDefault(u => u.correo_cep == email);
            return modulo.id_usuario_cep;
        }
        public static string SelectUserCepEmail(int id)
        {
            Usuarios_CEP ultimoModulo = Orm.bd.Usuarios_CEP.FirstOrDefault(u => u.id_usuario_cep == id);
            return ultimoModulo.correo_cep;
        }
    }
}
