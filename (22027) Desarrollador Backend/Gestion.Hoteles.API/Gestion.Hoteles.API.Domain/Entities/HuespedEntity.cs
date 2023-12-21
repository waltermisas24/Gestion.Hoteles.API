using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Entities
{
    public class HuespedEntity
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
