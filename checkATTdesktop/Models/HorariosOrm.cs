using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkATTdesktop.Models
{
    public static class HorariosOrm
    {
        public static List<Horario> Select(String id_clase, String diaSemana)
        {
            List<Horario> _horario = Orm.bd.Horario
                            .Where(c => c.id_clase == id_clase)
                            .Where(a => a.dia_semana_horario == diaSemana)
                            .ToList();
            return _horario;
        }
    }
}
