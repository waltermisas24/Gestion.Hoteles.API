using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class HabitacionReservaEntity
    {
        public int Id { get; set; }
        public int IdHotel { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public string Tipo { get; set; }
        public double Impuesto { get; set; }
        public int CantidadHuespedes { get; set; }
        public bool Habilitado { get; set; }
        public List<ReservacionEntity> Reservas { get; set; }
    }
}
