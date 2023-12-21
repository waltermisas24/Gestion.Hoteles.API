using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class DetalleReservacionEntity
    {
        public HotelEntity Hotel { get; set; }
        public List<HabitacionReservaEntity> Habitaciones { get; set; }
    }
}
