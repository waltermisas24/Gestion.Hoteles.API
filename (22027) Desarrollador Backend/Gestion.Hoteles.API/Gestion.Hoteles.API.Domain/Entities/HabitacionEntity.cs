using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class HabitacionEntity
    {
        public int Id { get; set; }
        [Column("Hotel_Id")]
        public int IdHotel { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        [Column("Tipo_Habitacion")]
        public string Tipo { get; set; }
        public double Impuesto { get; set; }
        [Column("Cantidad_Huespedes")]
        public int CantidadHuespedes { get; set; }
        public bool Habilitado { get; set; }
    }
}
