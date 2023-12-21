using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class ReservacionEntity
    {
        public int Id { get; set; }
        public int IdHabitacion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFinal { get; set; }
        public double Precio { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string TelefonoContactoEmergencia { get; set; }
        public bool Estado { get; set; }
        public List<HuespedEntity> Huespedes { get; set; }
    }
}
