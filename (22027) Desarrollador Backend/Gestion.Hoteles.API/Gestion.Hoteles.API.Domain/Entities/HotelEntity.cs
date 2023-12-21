using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class HotelEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Ubicacion { get; set; }
        public bool Habilitado { get; set; }
    }
}

