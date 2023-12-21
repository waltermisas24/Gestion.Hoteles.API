using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.DTO;

namespace Gestion.Hoteles.API.Mapper
{
    public class HotelMapper
    {
        public static HotelEntity MapHotelDTOToEntity(HotelDTO hotelDTO)
        {
            HotelEntity hotelEntity = new HotelEntity
            {
                Id = hotelDTO.Identificador,
                Habilitado = hotelDTO.Habilitado,
                Nombre = hotelDTO.Nombre,
                Ubicacion = hotelDTO.Ubicacion
            };

            return hotelEntity;
        }

        public static HotelDTO MapHotelEntityToDTO(HotelEntity hotelEntity)
        {
            HotelDTO hotelDTO = new HotelDTO
            {
                Identificador = hotelEntity.Id,
                Nombre = hotelEntity.Nombre,
                Ubicacion = hotelEntity.Ubicacion,
                Habilitado = hotelEntity.Habilitado
            };

            return hotelDTO;
        }
    }
}
