using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.DTO;

namespace Gestion.Hoteles.API.Mapper
{
    public class HabitacionMapper
    {
        public static HabitacionEntity MapHabitacionDTOToEntity(HabitacionDTO habitacionDTO)
        {
            HabitacionEntity habitacionEntity = new HabitacionEntity
            {
                Id = habitacionDTO.Identificador,
                IdHotel = habitacionDTO.IdentificadorHotel,
                Nombre = habitacionDTO.Nombre,
                Tipo = habitacionDTO.Tipo,
                Costo = habitacionDTO.Costo,
                Impuesto = habitacionDTO.Impuesto,
                CantidadHuespedes = habitacionDTO.CantidadHuespedes,
                Habilitado = habitacionDTO.Habilitado                
            };

            return habitacionEntity;
        }

        public static HabitacionDTO MapHabitacionEntityToDTO(HabitacionEntity habitacionEntity)
        {
            HabitacionDTO habitacionDTO = new HabitacionDTO 
            {
                Identificador = habitacionEntity.Id,
                IdentificadorHotel = habitacionEntity.IdHotel,
                Nombre = habitacionEntity.Nombre,
                Tipo = habitacionEntity.Tipo,
                Costo = habitacionEntity.Costo,
                Impuesto = habitacionEntity.Impuesto,
                CantidadHuespedes = habitacionEntity.CantidadHuespedes,
                Habilitado = habitacionEntity.Habilitado
            };

            return habitacionDTO;
        }
    }
}
