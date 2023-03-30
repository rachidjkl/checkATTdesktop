using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class HorariosOrm
    {
        public static List<Horario> Select(int id_clase, String diaSemana)
        {
            List<Horario> _horario = Orm.bd.Horario
                            .Where(c => c.id_clase == id_clase)
                            .Where(a => a.dia_semana_horario == diaSemana)
                            .ToList();
            return _horario;
        }

        public static String Insert(Horario horario)
        {
            String missatge = "";
            Orm.bd.Horario.Add(horario);

            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Update(Horario horario)
        {
            String missatge = "";
            Horario _horarioToEdit = Orm.bd.Horario.Where(a => a.id_horario == horario.id_horario).First();
            _horarioToEdit.hora_inicio = horario.hora_inicio;
            _horarioToEdit.hora_fin = horario.hora_fin;
            _horarioToEdit.id_clase = horario.id_clase;
            _horarioToEdit.id_modulo = horario.id_modulo;
            _horarioToEdit.dia_semana_horario = horario.dia_semana_horario;


            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(Horario horario)
        {
            String missatge = "";
            Orm.bd.Horario.Remove(horario);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

    }
}
